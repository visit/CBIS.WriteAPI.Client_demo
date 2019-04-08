using CBISimpaler.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBISimpaler.Services.Product
{
    public class Products : Credentials
    {
        public async Task<IList<string>> GetProductsForSubSystem(string subsystem, string orgId)
        {
            var GetAllProducts = await client.WriteAPI.GetActiveReferencesForSupplierWithHttpMessagesAsync(subsystem, orgId).ConfigureAwait(false);

            return GetAllProducts.Body;
        }

        //get /api/meta/supplier/{organization}/attribute
        public List<CBISImpaler.Models.CBISWriteAPIModelsAttribute> attributesList = new List<CBISImpaler.Models.CBISWriteAPIModelsAttribute>();

        public async Task GetAllAttributesForOrganization(string orgId)
        {
            var GetAllAttributes = await client.WriteAPI.GetAttributesForSupplierWithHttpMessagesAsync(orgId);

            foreach (var x in GetAllAttributes.Body)
            {
                attributesList.Add(x);
            }
        }

        public void DisplayAttributes(List<CBISImpaler.Models.CBISWriteAPIModelsAttribute> list)
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

        public void DisplayMultiAttributes(List<CBISImpaler.Models.CBISWriteAPIModelsAttribute> list)
        {
            foreach (var x in list.Where(y => y.AttributId >= 100000))
            {
                string display = string.Format("id: {0}, {1}", x.AttributId, x.Name);
                Console.WriteLine(display);
            }
        }

        //set /api/supplier/{organization}/information/{reference}
        public string SeralizeAttributeInput(JsonHandlerModel.JsonInformationData model)
        {
            return JsonConvert.SerializeObject(
                model,
                Formatting.None,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    Formatting = Formatting.Indented
                });
        }

        public async Task setData()
        {
            //var xuu = await client.WriteAPI.SetInformationForSupplierWithHttpMessagesAsync();
        }


        //public void SetValueRoute(int attributeId, int productId, dynamic value)
        //{
        //    int? language;

        //}

        //private async Task SetDoubleValue(int attributeId, int productId, double value)
        //{

        //}
        //private async Task SetIntValue(int attributeId, int productId, int value)
        //{

        //}
        //private async Task SetBoolValue(int attributeId, int productId, bool value)
        //{

        //}

        //private async Task SetStringValue(int attributeId, int productId, string value, int? language)
        //{

        //}

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

    public class JsonHandlerModel
    {
        public class JsonInformationData
        {
            public Set Set { get; set; }
            public Delete Delete { get; set; }

            public JsonInformationData()
            {
                Set = new Set();
                Delete = new Delete();
            }
        }

        public class Set
        {
            public Attribute Attribute { get; set; }
            public string Value { get; set; }
        }

        public class Attribute
        {
            public int AttributeId { get; set; }
            public string Culture { get; set; }
        }

        public class Delete
        {
            public int AttributeId { get; set; }
            public string Culture { get; set; }
        }
    }
}
