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

namespace NewPointe.JitBit.Structures.Generated
{
    public partial class Stats
    {
        [JsonProperty("TotalTickets")]
        public int TotalTickets { get; set; }

        [JsonProperty("Closed")]
        public int Closed { get; set; }

        [JsonProperty("InProcess")]
        public int InProcess { get; set; }

        [JsonProperty("NewTickets")]
        public int NewTickets { get; set; }

        [JsonProperty("Unanswered")]
        public int Unanswered { get; set; }

        [JsonProperty("Unassigned")]
        public int Unassigned { get; set; }

        [JsonProperty("Unclosed")]
        public int Unclosed { get; set; }
    }

}