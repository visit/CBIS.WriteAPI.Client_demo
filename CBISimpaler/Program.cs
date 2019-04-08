using CBISimpaler.Models;
using CBISimpaler.Services;
using CBISimpaler.Services.Product;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static CBISimpaler.Services.Product.JsonHandlerModel;

namespace CBISimpaler
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Startup s = new Startup();

            await s.Init();
        }
    }

    public class Startup : Credentials
    {
        private string orgRef;
        Helpers h = new Helpers();
        Products p = new Products();

        public async Task Init()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---CBIS Impaler---");
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter Username:");
            credentials.UserName = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            credentials.Password = h.PassWordMask();

            Console.WriteLine("\n");
            Console.WriteLine("-----------------");

            var ping = await client.WriteAPI.PingWithHttpMessagesAsync();

            if (!ping.Response.IsSuccessStatusCode || !ping.Body.Contains("pong"))
            {
                Console.WriteLine("Wrong Username or Password!");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Which organisation do you wish to work with?");
                orgRef = h.AsertCorrectOrgInput(Console.ReadLine());

                Console.WriteLine("Which attributeid should we update?");
                int attributeId = int.Parse(Console.ReadLine());

                //if translateable
                Console.WriteLine("Which culture?");
                string culture = Console.ReadLine();
                
                //refactor to allow various input types
                Console.WriteLine("What would you like the value to be?");
                string data = Console.ReadLine();


                Console.WriteLine("Are you sure?");
                ConsoleKeyInfo command = Console.ReadKey();

                switch (command.KeyChar)
                {
                    case 'y':

                        List<JsonInformationData> jsonstring = new List<JsonInformationData>();
                        
                        
                        setAttribute.AttributeId = attributeId;
                        setAttribute.Culture = culture;

                        Console.WriteLine(p.SeralizeAttributeInput(jsonstring));

                        break;
                }



                //var productsList = await p.GetProductsForSubSystem("cbis", orgRef);

                //int productsCount = productsList.Count;

                //Console.WriteLine(productsCount + " Products found!");

                //await p.GetAllAttributesForOrganization(orgRef);

                //Console.WriteLine("fafsads");
                //ConsoleKeyInfo command = Console.ReadKey();

                //switch (command.KeyChar)
                //{
                //    case 'a':
                //        Console.WriteLine("Displaying all Attributes:");
                //        Console.WriteLine("-------------------------------");
                //        p.DisplayAttributes(p.attributesList);
                //        break;
                //    case 'm':
                //        Console.WriteLine("Displaying all Multiattributes:");
                //        Console.WriteLine("-------------------------------");
                //        p.DisplayMultiAttributes(p.attributesList);
                //        break;
                //}

                //foreach (var x in productsList)
                //{
                //    Console.WriteLine(x);
                //}
            }

            Console.ReadLine();
        }
    }
}
