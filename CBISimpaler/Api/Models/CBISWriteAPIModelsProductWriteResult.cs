// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace CBISimpaler.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CBISWriteAPIModelsProductWriteResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CBISWriteAPIModelsProductWriteResult class.
        /// </summary>
        public CBISWriteAPIModelsProductWriteResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CBISWriteAPIModelsProductWriteResult class.
        /// </summary>
        public CBISWriteAPIModelsProductWriteResult(string reference = default(string), bool? hasChanged = default(bool?))
        {
            Reference = reference;
            HasChanged = hasChanged;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Reference")]
        public string Reference { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HasChanged")]
        public bool? HasChanged { get; set; }

    }
}
