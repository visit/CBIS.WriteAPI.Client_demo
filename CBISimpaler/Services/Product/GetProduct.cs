using CBISimpaler.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBISimpaler.Services.Product
{
    public class GetProducts : Credentials
    {
        public async Task<IList<string>> GetProductsForSubSystem(string subsystem, string orgId)
        {
            var GetAllProducts = await client.WriteAPI.GetActiveReferencesForSupplierWithHttpMessagesAsync(subsystem, orgId).ConfigureAwait(false);

            return GetAllProducts.Body;
        }

        //get /api/meta/supplier/{organization}/attribute
        public List<CBISimpaler.Models.CBISWriteAPIModelsAttribute> attributesList = new List<CBISimpaler.Models.CBISWriteAPIModelsAttribute>();

        public async Task GetAllAttributesForOrganization(string orgId)
        {
            var GetAllAttributes = await client.WriteAPI.GetAttributesForSupplierWithHttpMessagesAsync(orgId);

            foreach (var x in GetAllAttributes.Body)
            {
                attributesList.Add(x);
            }
        }

        public void DisplayAttributes(List<CBISimpaler.Models.CBISWriteAPIModelsAttribute> list)
        {
            foreach (var x in list.Where(y => y.AttributId < 100000))
            {
                string invariant = string.Empty;

                if (x.LanguageInvariant ?? true)
                {
                    invariant = "Cannot be translated.";
                }
                else
                {
                    invariant = "Must be translated.";
                }

                string display = string.Format("id: {0}, {1}, input type: {2}, {3}", x.AttributId, x.Name, x.Type, invariant);
                Console.WriteLine(display);
            }
        }

        public void DisplayMultiAttributes(List<CBISimpaler.Models.CBISWriteAPIModelsAttribute> list)
        {
            foreach (var x in list.Where(y => y.AttributId >= 100000))
            {
                string display = string.Format("id: {0}, {1}", x.AttributId, x.Name);
                Console.WriteLine(display);
            }
        }

    }

    public class Attribute
    {
        public int AttributId { get; set; }
        public bool LanguageInvariant { get; set; }
        public bool AllowHtml { get; set; }
        public Translations Translations { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class Translations
    {
        public string Title { get; set; }
        public string Value { get; set; }
    }

}
