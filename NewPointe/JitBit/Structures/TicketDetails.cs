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
    public class TicketDetails
    {
        public User SubmitterUserInfo { get; set; }
        public string CategoryName { get; set; }
        public User AssigneeUserInfo { get; set; }
        public string Url { get; set; }
        /// <summary>
        /// A list of Techs who are viewing the ticket (2019-04-29: The api doesn't seem to be returning this properly)
        /// </summary>
        public string[] ViewingTechNames { get; set; }
        public string Origin { get; set; }
        public dynamic[] Tags { get; set; }
        public string OnBehalfUserName { get; set; }
        public dynamic Integrations { get; set; }
        public DateTime IssueDate { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int Priority { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? StartDate { get; set; }
        public int TimeSpentInSeconds { get; set; }
        public DateTime LastUpdated { get; set; }
        public bool UpdatedByUser { get; set; }
        public bool UpdatedByPerformer { get; set; }
        public bool UpdatedForTechView { get; set; }
        public TicketAttachment[] Attachments  { get; set; }
        public string Status {get; set; }
        public bool StatusStopTimeSpent {get; set; }
        public int StatusID {get; set; }
        public int TicketID {get; set; }
        public int UserID {get; set; }
        public int? AssignedToUserID {get; set; }
        public int? CategoryID {get; set; }
        public bool? ResolvedDate {get; set; }
        public bool IsCurrentUserTechInThisCategory {get; set; }
        public bool SubmittedByCurrentUser {get; set; }
    }

}