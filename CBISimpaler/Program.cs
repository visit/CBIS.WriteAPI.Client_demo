using CBISimpaler.Models;
using CBISimpaler.Services;
using System;
using System.Threading.Tasks;

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
        public async Task Init()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---CBIS Impaler---");
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter Username:");
            credentials.UserName = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            credentials.Password = Globals.helpers.PassWordMask();

            Console.WriteLine("\n");
            Console.WriteLine("-----------------");

            var ping = await client.WriteAPI.PingWithHttpMessagesAsync();

            if (!ping.Response.IsSuccessStatusCode || !ping.Body.Contains("pong"))
            {
                Console.WriteLine("Wrong Username or Password!");
            }
            else
            {
                GetSetOrgId();
                Globals.helpers.MainMenu();

                Console.ReadLine();
            }
        }

        private void GetSetOrgId()
        {
            Console.WriteLine("");
            Console.WriteLine("Which organisation do you wish to work with?");
            Globals.orgRef = Globals.helpers.AsertCorrectOrgInput(Console.ReadLine());
        }
    }
}
