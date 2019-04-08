// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace CBISimpaler.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CBISWriteAPIModelsOrganizationAddress
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CBISWriteAPIModelsOrganizationAddress class.
        /// </summary>
        public CBISWriteAPIModelsOrganizationAddress()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CBISWriteAPIModelsOrganizationAddress class.
        /// </summary>
        public CBISWriteAPIModelsOrganizationAddress(string street1 = default(string), string street2 = default(string), string street3 = default(string), string postalCode = default(string), string city = default(string), string state = default(string), string countryCode = default(string))
        {
            Street1 = street1;
            Street2 = street2;
            Street3 = street3;
            PostalCode = postalCode;
            City = city;
            State = state;
            CountryCode = countryCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Street1")]
        public string Street1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Street2")]
        public string Street2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Street3")]
        public string Street3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PostalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "City")]
        public string City { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "State")]
        public string State { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CountryCode")]
        public string CountryCode { get; set; }

    }
}
