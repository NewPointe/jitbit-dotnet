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

    public partial class Ticket
    {
        [JsonProperty("SubmitterUserInfo")]
        public User SubmitterUserInfo { get; set; }

        [JsonProperty("CategoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("AssigneeUserInfo")]
        public User AssigneeUserInfo { get; set; }

        [JsonProperty("Url")]
        public Uri Url { get; set; }

        [JsonProperty("ViewingTechNames")]
        public dynamic[] ViewingTechNames { get; set; }

        [JsonProperty("Origin")]
        public string Origin { get; set; }

        [JsonProperty("Tags")]
        public dynamic[] Tags { get; set; }

        [JsonProperty("OnBehalfUserName")]
        public dynamic OnBehalfUserName { get; set; }

        [JsonProperty("Integrations")]
        public Dictionary<string, dynamic> Integrations { get; set; }

        [JsonProperty("IssueDate")]
        public DateTimeOffset IssueDate { get; set; }

        [JsonProperty("Subject")]
        public string Subject { get; set; }

        [JsonProperty("Body")]
        public string Body { get; set; }

        [JsonProperty("Priority")]
        public int Priority { get; set; }

        [JsonProperty("DueDate")]
        public DateTimeOffset DueDate { get; set; }

        [JsonProperty("StartDate")]
        public DateTimeOffset? StartDate { get; set; }

        [JsonProperty("TimeSpentInSeconds")]
        public int TimeSpentInSeconds { get; set; }

        [JsonProperty("LastUpdated")]
        public DateTimeOffset LastUpdated { get; set; }

        [JsonProperty("UpdatedByUser")]
        public bool UpdatedByUser { get; set; }

        [JsonProperty("UpdatedByPerformer")]
        public bool UpdatedByPerformer { get; set; }

        [JsonProperty("UpdatedForTechView")]
        public bool UpdatedForTechView { get; set; }

        [JsonProperty("Attachments")]
        public Attachment[] Attachments { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("StatusStopTimeSpent")]
        public bool StatusStopTimeSpent { get; set; }

        [JsonProperty("StatusID")]
        public int StatusId { get; set; }

        [JsonProperty("TicketID")]
        public int TicketId { get; set; }

        [JsonProperty("UserID")]
        public int UserId { get; set; }

        [JsonProperty("AssignedToUserID")]
        public int AssignedToUserId { get; set; }

        [JsonProperty("CategoryID")]
        public int CategoryId { get; set; }

        [JsonProperty("ResolvedDate")]
        public DateTimeOffset? ResolvedDate { get; set; }

        [JsonProperty("IsCurrentUserTechInThisCategory")]
        public bool IsCurrentUserTechInThisCategory { get; set; }

        [JsonProperty("SubmittedByCurrentUser")]
        public bool SubmittedByCurrentUser { get; set; }
    }

}