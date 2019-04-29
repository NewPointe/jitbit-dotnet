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

    public class TicketAttachment
    {
        public string FileName { get; set; }
        public int FileID { get; set; }
        public int CommentID { get; set; }
        public DateTime CommentDate { get; set; }
        public string FileHash { get; set; }
        public int FileSize { get; set; }
        public int IssueID { get; set; }
        public int InstanceID { get; set; }
        public int? AssetID { get; set; }
        public int UserID { get; set; }
        public string GoogleDriveUrl { get; set; }
        public string DropboxUrl { get; set; }
        public bool ForTechsOnly { get; set; }
        public bool CommentIsSystem { get; set; }
        public bool? IsDuplicate { get; set; }
        public string Url { get; set; }
        public string UrlRelative { get; set; }
    }

}