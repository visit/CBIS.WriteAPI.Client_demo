// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace CBISImpaler.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CBISWriteAPIModelsQueryCreateProduct
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CBISWriteAPIModelsQueryCreateProduct class.
        /// </summary>
        public CBISWriteAPIModelsQueryCreateProduct()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CBISWriteAPIModelsQueryCreateProduct class.
        /// </summary>
        public CBISWriteAPIModelsQueryCreateProduct(string product = default(string), string parentProduct = default(string), string name = default(string), int? template = default(int?))
        {
            Product = product;
            ParentProduct = parentProduct;
            Name = name;
            Template = template;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Product")]
        public string Product { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ParentProduct")]
        public string ParentProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Template")]
        public int? Template { get; set; }

    }
}
