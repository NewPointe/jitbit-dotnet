//-----------------------------------------------------------------------
// <copyright>
//     This Source Code Form is subject to the terms of the Mozilla Public
//     License, v. 2.0. If a copy of the MPL was not distributed with this
//     file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
//-----------------------------------------------------------------------

using System;

namespace NewPointe.JitBit.Structures
{

    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public bool Disabled { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Notes { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string CompanyName { get; set; }
        public string DepartmentName { get; set; }
        public string IPAddress { get; set; }
        public string HostName { get; set; }
        public string Lang { get; set; }
        public string UserAgent { get; set; }
        public string AvatarURL { get; set; }
        public string Signature { get; set; }
        public string Greeting { get; set; }
        public int? CompanyId { get; set; }
        public int? DepartmentID { get; set; }
        public string CompanyNotes { get; set; }
        public bool SendEmail { get; set; }
        public bool IsTech { get; set; }
        public DateTime LastSeen { get; set; }
        public string RecentTickets { get; set; }
        public bool IsManager { get; set; }
        public bool TwoFactorAuthEnabled { get; set; }
        public string FullNameAndLogin { get; set; }
        public string FullName { get; set; }
    }
}