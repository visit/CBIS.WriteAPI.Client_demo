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

    public partial class CBISWriteAPIModelsGeo
    {
        /// <summary>
        /// Initializes a new instance of the CBISWriteAPIModelsGeo class.
        /// </summary>
        public CBISWriteAPIModelsGeo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CBISWriteAPIModelsGeo class.
        /// </summary>
        public CBISWriteAPIModelsGeo(int? id = default(int?), string name = default(string), IList<CBISWriteAPIModelsGeo> children = default(IList<CBISWriteAPIModelsGeo>))
        {
            Id = id;
            Name = name;
            Children = children;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Children")]
        public IList<CBISWriteAPIModelsGeo> Children { get; set; }

    }
}