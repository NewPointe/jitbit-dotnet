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
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NewPointe.JitBit.Structures
{
    public class TicketFilter
    {
        public TicketFilterMode? Mode { get; set; }
        public int? CategoryId { get; set; }
        public int? SectionId { get; set; }
        public int[] StatusIds { get; set; }
        public int? FromUserId { get; set; }
        public int? FromCompanyId { get; set; }
        public int? HandledByUserId { get; set; }
        public string TagName { get; set; }
        public DateTimeOffset? DateCreatedMin { get; set; }
        public DateTimeOffset? DateCreatedMax { get; set; }
        public DateTimeOffset? DateUpdatedMin { get; set; }
        public DateTimeOffset? DateUpdatedMax { get; set; }
        public int? Count { get; set; }
        public int? Offset { get; set; }

        public string BuildQueryString()
        {

            var qs = new QueryString();

            if (Mode.HasValue) qs.Add("mode", Mode.Value.ToString().ToLowerInvariant());
            
            if (CategoryId.HasValue) qs.Add("categoryid", CategoryId.Value);
            if (SectionId.HasValue) qs.Add("sectionId", SectionId.Value);
            
            if (StatusIds != null) foreach (var status in StatusIds) qs.Add("sectionId", status);
            
            if (FromUserId.HasValue) qs.Add("fromUserId", FromUserId.Value);
            if (FromCompanyId.HasValue) qs.Add("fromCompanyId", FromCompanyId.Value);
            if (HandledByUserId.HasValue) qs.Add("handledByUserID", HandledByUserId.Value);
            
            if (!string.IsNullOrWhiteSpace(TagName)) qs.Add("tagName", TagName);

            if (DateCreatedMin.HasValue) qs.Add("dateFrom", DateCreatedMin.Value.ToString("yyyy-dd-MM"));
            if (DateCreatedMax.HasValue) qs.Add("dateTo", DateCreatedMax.Value.ToString("yyyy-dd-MM"));
            if (DateUpdatedMin.HasValue) qs.Add("updatedFrom", DateUpdatedMin.Value.ToString("yyyy-dd-MM"));
            if (DateUpdatedMax.HasValue) qs.Add("updatedTo", DateUpdatedMax.Value.ToString("yyyy-dd-MM"));

            if (Count.HasValue) qs.Add("count", Count.Value);
            if (Offset.HasValue) qs.Add("offset", Offset.Value);

            return qs.Build();

        }

    }

}