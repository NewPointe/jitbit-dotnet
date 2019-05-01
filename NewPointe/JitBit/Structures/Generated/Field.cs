//-----------------------------------------------------------------------
// <copyright>
//     This Source Code Form is subject to the terms of the Mozilla Public
//     License, v. 2.0. If a copy of the MPL was not distributed with this
//     file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NewPointe.JitBit.Structures
{
    public partial class Field
    {
        [JsonProperty("Value")]
        public string Value { get; set; }

        [JsonProperty("OptionID")]
        public int? OptionId { get; set; }

        [JsonProperty("FieldName")]
        public string FieldName { get; set; }

        [JsonProperty("FieldID")]
        public int FieldId { get; set; }

        [JsonProperty("Type")]
        public FieldType Type { get; set; }

        [JsonProperty("UsageType")]
        public int UsageType { get; set; }

        [JsonProperty("AccessType")]
        public int AccessType { get; set; }

        [JsonProperty("Mandatory")]
        public bool Mandatory { get; set; }

        [JsonProperty("OrderByNumber")]
        public int OrderByNumber { get; set; }

        [JsonProperty("ShowInGrid")]
        public bool ShowInGrid { get; set; }

        [JsonProperty("SelectionComboOptions")]
        public dynamic SelectionComboOptions { get; set; }
    }

}