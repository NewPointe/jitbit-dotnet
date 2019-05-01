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

    public partial class Asset
    {
        [JsonProperty("Tickets")]
        public dynamic Tickets { get; set; }

        [JsonProperty("AssignedUsers")]
        public User[] AssignedUsers { get; set; }

        [JsonProperty("Fields")]
        public Field[] Fields { get; set; }

        [JsonProperty("Attachments")]
        public dynamic Attachments { get; set; }

        [JsonProperty("LogEntries")]
        public dynamic LogEntries { get; set; }

        [JsonProperty("ItemID")]
        public int ItemId { get; set; }

        [JsonProperty("Manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("Supplier")]
        public string Supplier { get; set; }

        [JsonProperty("ModelName")]
        public string ModelName { get; set; }

        [JsonProperty("TypeID")]
        public int? TypeId { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("ManufacturerID")]
        public int? ManufacturerId { get; set; }

        [JsonProperty("SupplierID")]
        public int? SupplierId { get; set; }

        [JsonProperty("SerialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("Location")]
        public string Location { get; set; }

        [JsonProperty("Comments")]
        public string Comments { get; set; }

        [JsonProperty("Quantity")]
        public int Quantity { get; set; }

        [JsonProperty("TicketCount")]
        public int TicketCount { get; set; }

        [JsonProperty("Company")]
        public string Company { get; set; }

        [JsonProperty("CompanyID")]
        public int? CompanyId { get; set; }

        [JsonProperty("Disabled")]
        public bool? Disabled { get; set; }
    }

}
