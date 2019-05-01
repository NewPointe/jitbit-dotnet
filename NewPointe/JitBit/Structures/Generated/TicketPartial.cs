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
    public partial class TicketPartial
    {
        [JsonProperty("IssueID")]
        public int IssueId { get; set; }

        [JsonProperty("Priority")]
        public int Priority { get; set; }

        [JsonProperty("StatusID")]
        public int StatusId { get; set; }

        [JsonProperty("IssueDate")]
        public DateTimeOffset IssueDate { get; set; }

        [JsonProperty("Subject")]
        public string Subject { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("UpdatedByUser")]
        public bool UpdatedByUser { get; set; }

        [JsonProperty("UpdatedByPerformer")]
        public bool UpdatedByPerformer { get; set; }

        [JsonProperty("CategoryID")]
        public int CategoryId { get; set; }

        [JsonProperty("UserName")]
        public string UserName { get; set; }

        [JsonProperty("Technician")]
        public string Technician { get; set; }

        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [JsonProperty("DueDate")]
        public DateTimeOffset? DueDate { get; set; }

        [JsonProperty("TechFirstName")]
        public string TechFirstName { get; set; }

        [JsonProperty("TechLastName")]
        public string TechLastName { get; set; }

        [JsonProperty("LastUpdated")]
        public DateTimeOffset LastUpdated { get; set; }

        [JsonProperty("UpdatedForTechView")]
        public bool UpdatedForTechView { get; set; }

        [JsonProperty("UserID")]
        public int UserId { get; set; }

        [JsonProperty("CompanyID")]
        public int? CompanyId { get; set; }

        [JsonProperty("CompanyName")]
        public string CompanyName { get; set; }

        [JsonProperty("AssignedToUserID")]
        public int? AssignedToUserId { get; set; }

        [JsonProperty("ResolvedDate")]
        public DateTimeOffset? ResolvedDate { get; set; }

        [JsonProperty("SectionID")]
        public int? SectionId { get; set; }

        [JsonProperty("Category")]
        public string Category { get; set; }

        [JsonProperty("Origin")]
        public string Origin { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("ViewingTechs")]
        public dynamic ViewingTechs { get; set; }
    }

}