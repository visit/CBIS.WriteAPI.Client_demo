// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace CBISimpaler.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CBISWriteAPIModelsOrganizationReference
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CBISWriteAPIModelsOrganizationReference class.
        /// </summary>
        public CBISWriteAPIModelsOrganizationReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CBISWriteAPIModelsOrganizationReference class.
        /// </summary>
        public CBISWriteAPIModelsOrganizationReference(string localName = default(string), string subSystem = default(string))
        {
            LocalName = localName;
            SubSystem = subSystem;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LocalName")]
        public string LocalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubSystem")]
        public string SubSystem { get; set; }

    }
}
