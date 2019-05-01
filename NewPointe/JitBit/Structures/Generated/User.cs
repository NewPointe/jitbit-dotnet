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

    public partial class User
    {
        [JsonProperty("UserID")]
        public int UserId { get; set; }

        [JsonProperty("Username")]
        public string Username { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("IsAdmin")]
        public bool IsAdmin { get; set; }

        [JsonProperty("Disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [JsonProperty("Notes")]
        public string Notes { get; set; }

        [JsonProperty("Location")]
        public string Location { get; set; }

        [JsonProperty("Phone")]
        public string Phone { get; set; }

        [JsonProperty("CompanyName")]
        public string CompanyName { get; set; }

        [JsonProperty("DepartmentName")]
        public string DepartmentName { get; set; }

        [JsonProperty("IPAddress")]
        public string IpAddress { get; set; }

        [JsonProperty("HostName")]
        public string HostName { get; set; }

        [JsonProperty("Lang")]
        public string Lang { get; set; }

        [JsonProperty("UserAgent")]
        public string UserAgent { get; set; }

        [JsonProperty("AvatarURL")]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("Signature")]
        public string Signature { get; set; }

        [JsonProperty("Greeting")]
        public string Greeting { get; set; }

        [JsonProperty("CompanyId")]
        public int? CompanyId { get; set; }

        [JsonProperty("DepartmentID")]
        public int? DepartmentId { get; set; }

        [JsonProperty("CompanyNotes")]
        public string CompanyNotes { get; set; }

        [JsonProperty("SendEmail")]
        public bool SendEmail { get; set; }

        [JsonProperty("IsTech")]
        public bool IsTech { get; set; }

        [JsonProperty("LastSeen")]
        public DateTimeOffset? LastSeen { get; set; }

        [JsonProperty("RecentTickets")]
        public dynamic RecentTickets { get; set; }

        [JsonProperty("IsManager")]
        public bool IsManager { get; set; }

        [JsonProperty("TwoFactorAuthEnabled")]
        public bool TwoFactorAuthEnabled { get; set; }

        [JsonProperty("FullNameAndLogin")]
        public string FullNameAndLogin { get; set; }

        [JsonProperty("FullName")]
        public string FullName { get; set; }
    }

}