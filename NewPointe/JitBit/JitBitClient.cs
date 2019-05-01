//-----------------------------------------------------------------------
// <copyright>
//     This Source Code Form is subject to the terms of the Mozilla Public
//     License, v. 2.0. If a copy of the MPL was not distributed with this
//     file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using NewPointe.JitBit.Structures;

namespace NewPointe.JitBit
{

    public class JitBitClient
    {

        private readonly HttpClient client;

        public JitBitClient(string server) : this(new Uri(server)) { }
        public JitBitClient(Uri server)
        {
            client = new HttpClient();
            client.BaseAddress = server;
            client.DefaultRequestHeaders.Add("User-Agent", GetType().FullName);
        }
        public JitBitClient(HttpClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Sets up and tests API authentication.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns>The User.</returns>
        public async Task<User> Login(string username, string password)
        {
            var basicAuthToken = Convert.ToBase64String(Encoding.ASCII.GetBytes(username + ":" + password));
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", basicAuthToken);

            var result = await client.GetAsync("api/Authorization");
            result.EnsureSuccessStatusCode();
            return await result.Content.ReadAsAsync<User>();
        }



        #region Tickets

        public async Task<TicketPartial[]> GetTickets(GetTicketsParameters filter)
        {

            var result = await client.GetAsync("api/Tickets?" + filter.GetQueryString());
            result.EnsureSuccessStatusCode();
            return await result.Content.ReadAsAsync<TicketPartial[]>();

        }

        #endregion


        #region Assets

        /// <summary>
        /// Gets all Assets from Jitbit.
        /// </summary>
        /// <param name="pageLimit">The maximum number of pages to retrieve. Defaults to 10.</param>
        /// <returns>An array of Assets.</returns>
        public async Task<Asset[]> GetAllAssets(int pageLimit = 10)
        {

            // A List for all of our assets
            List<Asset> assets = new List<Asset>();

            // Temp variables for the current page
            int currentPageNumber = 1;
            Asset[] currentPageResults = new Asset[0];

            // Loop until we hit the page limit or don't get a full page (50 items) back
            do
            {

                // Get the page
                currentPageResults = await GetAssets(new GetAssetsParameters { Page = currentPageNumber });

                // Add to our list
                assets.AddRange(currentPageResults);

                // Bump the page number
                currentPageNumber = currentPageNumber + 1;

            }
            while (currentPageNumber < pageLimit && currentPageResults.Length == 50);

            return assets.ToArray();

        }

        /// <summary>
        /// Gets a page of Assets from Jitbit.
        /// </summary>
        /// <param name="page">The page number.</param>
        /// <returns>An array of Assets</returns>
        public async Task<Asset[]> GetAssets(GetAssetsParameters parameters)
        {
            var result = await client.GetAsync("api/Assets?" + parameters.GetQueryString());
            result.EnsureSuccessStatusCode();
            return await result.Content.ReadAsAsync<Asset[]>();
        }

        public async Task<int> CreateAsset(CreateAssetParameters newAsset) {
            var result = await client.PostAsJsonAsync("/api/Asset", newAsset);
            result.EnsureSuccessStatusCode();
            return (await result.Content.ReadAsAsync<CreateAssetResponse>()).Id;
        }

        public async Task<Asset> UpdateAsset(UpdateAssetParameters updatedAsset) {
            var result = await client.PostAsJsonAsync("/api/UpdateAsset", updatedAsset);
            result.EnsureSuccessStatusCode();
            return await result.Content.ReadAsAsync<Asset>();
        }

        public async Task<HttpResponseMessage> SetCustomAssetField(SetCustomAssetFieldParameters field) {
            var result = await client.PostAsJsonAsync("/api/SetCustomFieldForAsset", field);
            result.EnsureSuccessStatusCode();
            return result;
        }

        #endregion


        #region Stats

        /// <summary>
        /// Gets ticket statistics.
        /// </summary>
        /// <returns>The stats</returns>
        public async Task<Stats> GetStats()
        {

            var result = await client.GetAsync("api/Stats");
            result.EnsureSuccessStatusCode();
            return await result.Content.ReadAsAsync<Stats>();

        }

        #endregion

    }
}