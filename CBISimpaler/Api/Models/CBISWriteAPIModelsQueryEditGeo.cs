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

    public partial class CBISWriteAPIModelsQueryEditGeo
    {
        /// <summary>
        /// Initializes a new instance of the CBISWriteAPIModelsQueryEditGeo
        /// class.
        /// </summary>
        public CBISWriteAPIModelsQueryEditGeo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CBISWriteAPIModelsQueryEditGeo
        /// class.
        /// </summary>
        public CBISWriteAPIModelsQueryEditGeo(IList<int?> set = default(IList<int?>), IList<int?> delete = default(IList<int?>))
        {
            Set = set;
            Delete = delete;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Set")]
        public IList<int?> Set { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Delete")]
        public IList<int?> Delete { get; set; }

    }
}
