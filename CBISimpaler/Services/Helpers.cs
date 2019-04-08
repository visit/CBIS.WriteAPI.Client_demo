using CBISimpaler.Services.Organization;
using CBISimpaler.Services.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace CBISimpaler.Services
{
    public static class Globals
    {
        public static string orgRef;
        public static SetProduct setProducts = new SetProduct();
        public static Helpers helpers = new Helpers();
        public static GetProducts getProducts = new GetProducts();
        public static OrganizationServices org = new OrganizationServices(orgRef);
    }

    public class Helpers
    {
        public string PassWordMask()
        {
            string pass = "";
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                // Backspace Should Not Work
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    pass += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                    {
                        pass = pass.Substring(0, (pass.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            } while (true);

            return pass;
        }

        public string AsertCorrectOrgInput(string input)
        {
            string output = string.Empty;

            if (!input.StartsWith("cbis:"))
            {
                if (int.TryParse(input, out int result))
                {
                    output = "cbis:" + input;
                }
            }

            return output;
        }

        public void MainMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Main Menu");
            Console.WriteLine("");
            Console.WriteLine("1. Update product information for a specific product.");
            Console.WriteLine("2. Update product information for all products on an organization.");
            Console.WriteLine("------------------------------------------------");

            ConsoleKeyInfo command = Console.ReadKey();
            Console.WriteLine("");

            switch (command.KeyChar)
            {
                case '1':
                    _ = Globals.setProducts.SetSingleProduct(Globals.orgRef);
                    break;

                    //add default value
            }

            //var productsList = await p.GetProductsForSubSystem("cbis", orgRef);

            //int productsCount = productsList.Count;

            //Console.WriteLine(productsCount + " Products found!");

            //await p.GetAllAttributesForOrganization(orgRef);

        }
    }
}

