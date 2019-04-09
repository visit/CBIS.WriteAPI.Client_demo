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

        //GET /api/supplier/{organization}/exists/{reference}
        public async Task<bool> CheckIfProductExists(string productReference, string orgId)
        {
            var Check = await client.WriteAPI.ProductExistsForSupplierAsync(productReference, orgId);

            return Check.Value;
        }

        //GET /api/meta/supplier/{organization}/attribute
        public async Task GetAllAttributesForOrganization(string orgId)
        {
            var GetAllAttributes = await client.WriteAPI.GetAttributesForSupplierWithHttpMessagesAsync(orgId);

            foreach (var x in GetAllAttributes.Body)
            {
                Globals.attributesList.Add(x);
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

}
