// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace CBISimpaler.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CBISWriteAPIModelsMediaTranslation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CBISWriteAPIModelsMediaTranslation class.
        /// </summary>
        public CBISWriteAPIModelsMediaTranslation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CBISWriteAPIModelsMediaTranslation class.
        /// </summary>
        public CBISWriteAPIModelsMediaTranslation(string name = default(string), string description = default(string), string keywords = default(string), string culture = default(string))
        {
            Name = name;
            Description = description;
            Keywords = keywords;
            Culture = culture;
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
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Keywords")]
        public string Keywords { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Culture")]
        public string Culture { get; set; }

    }
}
