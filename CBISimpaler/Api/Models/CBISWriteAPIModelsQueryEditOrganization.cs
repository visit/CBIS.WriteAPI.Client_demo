// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace CBISImpaler.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CBISWriteAPIModelsQueryEditOrganization
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CBISWriteAPIModelsQueryEditOrganization class.
        /// </summary>
        public CBISWriteAPIModelsQueryEditOrganization()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CBISWriteAPIModelsQueryEditOrganization class.
        /// </summary>
        public CBISWriteAPIModelsQueryEditOrganization(string name = default(string), string culture = default(string), CBISWriteAPIModelsOrganizationAddress address = default(CBISWriteAPIModelsOrganizationAddress))
        {
            Name = name;
            Culture = culture;
            Address = address;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Culture")]
        public string Culture { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Address")]
        public CBISWriteAPIModelsOrganizationAddress Address { get; set; }

    }
}