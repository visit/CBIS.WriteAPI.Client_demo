using CBISimpaler.Models;
using CBISimpaler.Services.Organization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBISimpaler.Services.Product
{
    public class SetProduct : Credentials
    {
        Startup s = new Startup();
        public static OrganizationServices org = new OrganizationServices(Globals.orgRef);

        public async Task SetSingleProduct(string orgRef)
        {
            Console.WriteLine("Which productreference should we update (remember to start with cbis: or similar)?");
            string productRef = Console.ReadLine();
            if(productRef.Contains(":"))
            {
                bool productExists = await Globals.getProducts.CheckIfProductExists(productRef, orgRef);

                if(productExists)
                {
                    (int attributeId, string culture, string data) = PrepareSetDataInputs();

                    Console.WriteLine("Are you sure?");
                    ConsoleKeyInfo command = Console.ReadKey();
                    Console.WriteLine("");

                    switch (command.KeyChar)
                    {
                        case 'y':

                            CBISWriteAPIModelsQueryEditInformation jsonString = PrepareSetData(attributeId, culture, data);

                            await setData(productRef, orgRef, jsonString);

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Done!");

                            break;

                        default:
                            await Globals.helpers.MainMenu();
                            break;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error! Exiting application.");
                return;
            }
        }

        public async Task SetMultipleProducts(string orgRef)
        {
            Console.WriteLine("Which subsystem do your products belong to (like cbis, ptg or bv)?");
            string subsystem = Console.ReadLine();
            
            IList<string> products = await Globals.getProducts.GetProductsForSubSystem(subsystem, orgRef);
            Console.Write(String.Format(" - {0} products found.", products.Count));
            Console.WriteLine("");

            (int attributeId, string culture, string data) = PrepareSetDataInputs();

            Console.WriteLine(String.Format("This will update {0} products.", products.Count));
            Console.WriteLine("Are you sure?");
            ConsoleKeyInfo command = Console.ReadKey();
            Console.WriteLine("");

            switch (command.KeyChar)
            {
                case 'y':

                    CBISWriteAPIModelsQueryEditInformation jsonString = PrepareSetData(attributeId, culture, data);

                    foreach (var productRef in products)
                    {
                       await setData(productRef, orgRef, jsonString);
                    }

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Done!");

                    break;

                default:
                    await Globals.helpers.MainMenu();
                    break;
            }
        }

        private (int, string, string) PrepareSetDataInputs()
        {
            string culture = default;
            bool isInvariant = false;
            string attributeType = default;
            int _attributeId;

            Console.WriteLine("Which attributeid should we update?");
            int attributeId = int.Parse(Console.ReadLine());
            _attributeId = attributeId;

            Globals.attributesList.Where(x => x.AttributId == _attributeId).Select(x => new { isInvariant = x.LanguageInvariant, attributeType = x.Type });

            if (!isInvariant)
            {
                culture = SelectedCulture();
            }

            //refactor to allow various input types
            Console.WriteLine(String.Format("What would you like the value to be? Type is {0}",attributeType));
            string data = Console.ReadLine();

            return (attributeId, culture, data);
        }

        private string SelectedCulture()
        {
            Console.WriteLine("Select which language we should update.");
            Console.WriteLine("\n");

            org.ShowOrganizationCultures();

            int culturePick = int.Parse(Console.ReadKey().KeyChar.ToString());

            string culture = org.GetOrganizationCultures[culturePick];

            return culture;
        }

        private CBISWriteAPIModelsQueryEditInformation PrepareSetData(int attributeId, string culture, string data)
        {
            //refactor to allow multiple language and attributes
            CBISWriteAPIModelsInformationKey attribute = new CBISWriteAPIModelsInformationKey
            {
                AttributeId = attributeId,
                Culture = culture
            };

            //refactor to allow multiple language and attributes
            CBISWriteAPIModelsInformation infomodel = new CBISWriteAPIModelsInformation
            {
                Attribute = attribute,
                Value = data
            };

            var setList = new List<CBISWriteAPIModelsInformation>();
            setList.Add(infomodel);

            CBISWriteAPIModelsQueryEditInformation jsonstring = new CBISWriteAPIModelsQueryEditInformation
            {
                Set = setList,
                Delete = default
            };

            return jsonstring;
        }

        private async Task setData(string productReference, string orgId, CBISWriteAPIModelsQueryEditInformation json)
        {
            bool checker = false;
            string result = string.Empty;

            try
            {
                var set = await client.WriteAPI.SetInformationForSupplierWithHttpMessagesAsync(productReference, orgId, json);
                if (set.Response.IsSuccessStatusCode)
                {
                    checker = true;
                }
            }
            catch { }

            if (!checker)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Something went wrong. Product {0} did not update!", productReference);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Success! Product {0} has finished updating.", productReference);
            }
        }
    }
}
