using CBISimpaler.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CBISimpaler.Services.Organization
{
    public class OrganizationServices : Credentials
    {
        //GET /api/meta/supplier/{organization}/culture
        public Dictionary<int, string> GetOrganizationCultures = new Dictionary<int, string>();

        public OrganizationServices(string orgRef)
        {
            int counter = 1;

            var l = client.WriteAPI.GetLanguagesForSupplier(orgRef);

            foreach (var x in l)
            {
                GetOrganizationCultures.Add(counter, x);
                counter++;
            }
        }

        public void ShowOrganizationCultures()
        {
            foreach (var x in GetOrganizationCultures)
            {
                Console.WriteLine(x.Key + ": " + x.Value);
            }
        }

    }

}
