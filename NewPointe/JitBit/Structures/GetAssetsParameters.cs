//-----------------------------------------------------------------------
// <copyright>
//     This Source Code Form is subject to the terms of the Mozilla Public
//     License, v. 2.0. If a copy of the MPL was not distributed with this
//     file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
//-----------------------------------------------------------------------

using Newtonsoft.Json;

namespace NewPointe.JitBit.Structures
{

    public class GetAssetsParameters : IHaveQueryParameters
    {

        [JsonProperty("page")]
        public int? Page { get; set; }

        [JsonProperty("assignedToUserId")]
        public int? AssignedToUserId { get; set; }

        [JsonProperty("assignedToCompanyId")]
        public int? AssignedToCompanyId { get; set; }

        [JsonProperty("assignedToDepartmentId")]
        public int? AssignedToDepartmentId { get; set; }

        public string GetQueryString()
        {

            var qs = new QueryString();

            if (Page.HasValue) qs.Add("page", Page.Value);
            if (AssignedToUserId.HasValue) qs.Add("assignedToUserId", AssignedToUserId.Value);
            if (AssignedToCompanyId.HasValue) qs.Add("assignedToCompanyId", AssignedToCompanyId.Value);
            if (AssignedToDepartmentId.HasValue) qs.Add("assignedToDepartmentId", AssignedToDepartmentId.Value);

            return qs.Build();
        }
    }

}