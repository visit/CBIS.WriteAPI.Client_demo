// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace CBISImpaler.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class CBISWriteAPIModelsAllowedHtml
    {
        /// <summary>
        /// Initializes a new instance of the CBISWriteAPIModelsAllowedHtml
        /// class.
        /// </summary>
        public CBISWriteAPIModelsAllowedHtml()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CBISWriteAPIModelsAllowedHtml
        /// class.
        /// </summary>
        public CBISWriteAPIModelsAllowedHtml(IList<string> allowedTags = default(IList<string>), IList<string> allowedAttributes = default(IList<string>))
        {
            AllowedTags = allowedTags;
            AllowedAttributes = allowedAttributes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AllowedTags")]
        public IList<string> AllowedTags { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AllowedAttributes")]
        public IList<string> AllowedAttributes { get; set; }

    }
}