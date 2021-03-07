using Newtonsoft.Json;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHRCommon.Client
{
    [ExcludeFromCodeCoverage]
    public class ClientCall : IClientCall
    {
        private static HttpClient _client;
        public ClientCall()
        {

        }

        public async Task<string> CallRestMethod(string url, string token)
        {
            string result = string.Empty;
            try
            {
                //set the protocol manually as newer Web Api requires a different protocol
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                var authValue = new AuthenticationHeaderValue("Bearer", token);

                //set the client authorization apikey
                _client = new HttpClient() { DefaultRequestHeaders = { Authorization = authValue } };

                HttpResponseMessage response = await _client.GetAsync(url).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    throw new HttpRequestException(responseContent);
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> CallRestPostMethod(string url, string token)
        {
            bool result = false;
            try
            {
                var tokenParam = new
                {
                    tokenId = token
                };

                var json = JsonConvert.SerializeObject(tokenParam);
                var data = new StringContent(json, Encoding.UTF8, "application/json");


                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.PostAsync(url, data);
                    if (response.IsSuccessStatusCode)
                    {
                        result = true;
                    }

                }

                return result;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
