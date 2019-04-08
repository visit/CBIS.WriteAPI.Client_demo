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

    public partial class CBISWriteAPIModelsProduct
    {
        /// <summary>
        /// Initializes a new instance of the CBISWriteAPIModelsProduct class.
        /// </summary>
        public CBISWriteAPIModelsProduct()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CBISWriteAPIModelsProduct class.
        /// </summary>
        /// <param name="cBISReference">Gets or sets the identifier.</param>
        /// <param name="references">Gets or sets the reference names list for
        /// this product. Only names that are in lookup are available.</param>
        /// <param name="queryReference">Gets or sets the known names.</param>
        /// <param name="information">Gets or sets the information.</param>
        /// <param name="geoIds">Gets or sets the geo ids.</param>
        /// <param name="categories">Gets or sets the classifications.</param>
        /// <param name="media">Gets or sets the media.</param>
        /// <param name="occasions">Gets or sets a value indicating whether
        /// this instance has occasions.</param>
        /// <param name="parentProductId">Gets or sets the parent product
        /// identifier.</param>
        /// <param name="expireAt">Gets or sets the expire at.</param>
        /// <param name="publishAt">Gets the publish at.</param>
        /// <param name="status">Gets the status of the product. Possible
        /// values include: 'Active', 'Archived'</param>
        /// <param name="relevance">Gets the relevance. Possible values
        /// include: 'None', 'Local', 'Regional', 'National',
        /// 'International'</param>
        /// <param name="template">Gets the template.</param>
        public CBISWriteAPIModelsProduct(string cBISReference = default(string), IList<string> references = default(IList<string>), string queryReference = default(string), IList<CBISWriteAPIModelsInformation> information = default(IList<CBISWriteAPIModelsInformation>), IList<int?> geoIds = default(IList<int?>), IList<int?> categories = default(IList<int?>), IList<CBISWriteAPIModelsMedia> media = default(IList<CBISWriteAPIModelsMedia>), IList<CBISWriteAPIModelsOccasion> occasions = default(IList<CBISWriteAPIModelsOccasion>), string parentProductId = default(string), System.DateTime? expireAt = default(System.DateTime?), System.DateTime? publishAt = default(System.DateTime?), string status = default(string), string relevance = default(string), int? template = default(int?))
        {
            CBISReference = cBISReference;
            References = references;
            QueryReference = queryReference;
            Information = information;
            GeoIds = geoIds;
            Categories = categories;
            Media = media;
            Occasions = occasions;
            ParentProductId = parentProductId;
            ExpireAt = expireAt;
            PublishAt = publishAt;
            Status = status;
            Relevance = relevance;
            Template = template;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        [JsonProperty(PropertyName = "CBISReference")]
        public string CBISReference { get; set; }

        /// <summary>
        /// Gets or sets the reference names list for this product. Only names
        /// that are in lookup are available.
        /// </summary>
        [JsonProperty(PropertyName = "References")]
        public IList<string> References { get; set; }

        /// <summary>
        /// Gets or sets the known names.
        /// </summary>
        [JsonProperty(PropertyName = "QueryReference")]
        public string QueryReference { get; set; }

        /// <summary>
        /// Gets or sets the information.
        /// </summary>
        [JsonProperty(PropertyName = "Information")]
        public IList<CBISWriteAPIModelsInformation> Information { get; set; }

        /// <summary>
        /// Gets or sets the geo ids.
        /// </summary>
        [JsonProperty(PropertyName = "GeoIds")]
        public IList<int?> GeoIds { get; set; }

        /// <summary>
        /// Gets or sets the classifications.
        /// </summary>
        [JsonProperty(PropertyName = "Categories")]
        public IList<int?> Categories { get; set; }

        /// <summary>
        /// Gets or sets the media.
        /// </summary>
        [JsonProperty(PropertyName = "Media")]
        public IList<CBISWriteAPIModelsMedia> Media { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has
        /// occasions.
        /// </summary>
        [JsonProperty(PropertyName = "Occasions")]
        public IList<CBISWriteAPIModelsOccasion> Occasions { get; set; }

        /// <summary>
        /// Gets or sets the parent product identifier.
        /// </summary>
        [JsonProperty(PropertyName = "ParentProductId")]
        public string ParentProductId { get; set; }

        /// <summary>
        /// Gets or sets the expire at.
        /// </summary>
        [JsonProperty(PropertyName = "ExpireAt")]
        public System.DateTime? ExpireAt { get; set; }

        /// <summary>
        /// Gets the publish at.
        /// </summary>
        [JsonProperty(PropertyName = "PublishAt")]
        public System.DateTime? PublishAt { get; set; }

        /// <summary>
        /// Gets the status of the product. Possible values include: 'Active',
        /// 'Archived'
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets the relevance. Possible values include: 'None', 'Local',
        /// 'Regional', 'National', 'International'
        /// </summary>
        [JsonProperty(PropertyName = "Relevance")]
        public string Relevance { get; set; }

        /// <summary>
        /// Gets the template.
        /// </summary>
        [JsonProperty(PropertyName = "Template")]
        public int? Template { get; set; }

    }
}
