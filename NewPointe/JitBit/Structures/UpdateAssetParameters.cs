//-----------------------------------------------------------------------
// <copyright>
//     This Source Code Form is subject to the terms of the Mozilla Public
//     License, v. 2.0. If a copy of the MPL was not distributed with this
//     file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
//-----------------------------------------------------------------------

using Newtonsoft.Json;

namespace NewPointe.JitBit.Structures
{

    public class UpdateAssetParameters
    {

        [JsonProperty("modelName")]
        public string ModelName { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("supplier")]
        public string Supplier { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
        
        [JsonProperty("comments")]
        public string Comments { get; set; }
        
        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

    }

}