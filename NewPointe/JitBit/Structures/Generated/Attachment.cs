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
    public partial class Attachment
    {
        [JsonProperty("FileName")]
        public string FileName { get; set; }

        [JsonProperty("FileID")]
        public int FileId { get; set; }

        [JsonProperty("CommentID")]
        public int CommentId { get; set; }

        [JsonProperty("CommentDate")]
        public DateTimeOffset CommentDate { get; set; }

        [JsonProperty("FileHash")]
        public dynamic FileHash { get; set; }

        [JsonProperty("FileSize")]
        public int FileSize { get; set; }

        [JsonProperty("HiddenFromKB")]
        public bool HiddenFromKb { get; set; }

        [JsonProperty("HiddenFromTickets")]
        public bool HiddenFromTickets { get; set; }

        [JsonProperty("IssueID")]
        public int IssueId { get; set; }

        [JsonProperty("InstanceID")]
        public int InstanceId { get; set; }

        [JsonProperty("AssetID")]
        public dynamic AssetId { get; set; }

        [JsonProperty("UserID")]
        public int UserId { get; set; }

        [JsonProperty("GoogleDriveUrl")]
        public dynamic GoogleDriveUrl { get; set; }

        [JsonProperty("DropboxUrl")]
        public dynamic DropboxUrl { get; set; }

        [JsonProperty("ForTechsOnly")]
        public bool ForTechsOnly { get; set; }

        [JsonProperty("CommentIsSystem")]
        public bool CommentIsSystem { get; set; }

        [JsonProperty("IsDuplicate")]
        public dynamic IsDuplicate { get; set; }

        [JsonProperty("Url")]
        public Uri Url { get; set; }

        [JsonProperty("UrlRelative")]
        public string UrlRelative { get; set; }
    }

}