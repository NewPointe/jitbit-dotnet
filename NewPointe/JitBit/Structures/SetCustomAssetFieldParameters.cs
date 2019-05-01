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

    public class SetCustomAssetFieldParameters
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("fieldId")]
        public int FieldId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
        
    }

}