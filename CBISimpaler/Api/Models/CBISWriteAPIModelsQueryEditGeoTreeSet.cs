// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace CBISImpaler.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CBISWriteAPIModelsQueryEditGeoTreeSet
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CBISWriteAPIModelsQueryEditGeoTreeSet class.
        /// </summary>
        public CBISWriteAPIModelsQueryEditGeoTreeSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CBISWriteAPIModelsQueryEditGeoTreeSet class.
        /// </summary>
        public CBISWriteAPIModelsQueryEditGeoTreeSet(int? parentId = default(int?), string name = default(string))
        {
            ParentId = parentId;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ParentId")]
        public int? ParentId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

    }
}