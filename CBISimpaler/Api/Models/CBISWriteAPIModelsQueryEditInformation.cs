// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace CBISimpaler.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class CBISWriteAPIModelsQueryEditInformation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CBISWriteAPIModelsQueryEditInformation class.
        /// </summary>
        public CBISWriteAPIModelsQueryEditInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CBISWriteAPIModelsQueryEditInformation class.
        /// </summary>
        public CBISWriteAPIModelsQueryEditInformation(IList<CBISWriteAPIModelsInformation> set = default(IList<CBISWriteAPIModelsInformation>), IList<CBISWriteAPIModelsInformationKey> delete = default(IList<CBISWriteAPIModelsInformationKey>))
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
        public IList<CBISWriteAPIModelsInformation> Set { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Delete")]
        public IList<CBISWriteAPIModelsInformationKey> Delete { get; set; }

    }
}
