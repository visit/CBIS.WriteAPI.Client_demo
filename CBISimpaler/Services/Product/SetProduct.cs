using CBISimpaler.Models;
using CBISimpaler.Services.Organization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CBISimpaler.Services.Product
{
    public class SetProduct : Credentials
    {
        Startup s = new Startup();

        public async Task SetSingleProduct(string orgRef)
        {
            OrganizationServices org = new OrganizationServices(orgRef);

            Console.WriteLine("Which attributeid should we update?");
            int attributeId = int.Parse(Console.ReadLine());

            //if translateable
            Console.WriteLine("Which culture?");
            Console.WriteLine("\n");

            org.ShowOrganizationCultures();

            int culturePick = int.Parse(Console.ReadKey().KeyChar.ToString());

            string culture = org.GetOrganizationCultures[culturePick];

            //refactor to allow various input types
            Console.WriteLine("What would you like the value to be?");
            string data = Console.ReadLine();

            Console.WriteLine("Are you sure?");
            ConsoleKeyInfo command = Console.ReadKey();
            Console.WriteLine("");

            switch (command.KeyChar)
            {
                case 'y':

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

                    await setData("cbis:1741743", orgRef, jsonstring);

                    break;

                default:
                    Globals.helpers.MainMenu();
                    break;
            }
        }

        public async Task setData(string productReference, string orgId, CBISWriteAPIModelsQueryEditInformation json)
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
