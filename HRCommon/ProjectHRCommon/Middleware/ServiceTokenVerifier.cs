using Microsoft.AspNetCore.Authorization;
using ProjectHRCommon.Client;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http;
using System;
using Newtonsoft.Json;
using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace ProjectHRCommon.Middleware
{
    [ExcludeFromCodeCoverage]
    public class ServiceTokenVerifier : IAuthorizationRequirement
    {   
        private readonly IClientCall _clientCall;
        private readonly string _url;
        private static HttpClient _client;

        public ServiceTokenVerifier(IClientCall clientCall, string url)
        {
            _clientCall = clientCall;
            _url = url;
        }

        public async Task<bool> IsTokenVerified(string token)
        {
            var result = await Task.Run(async () => await CallRestPostMethod(_url, token));
            return result;     
        }

        
        public async Task<string> CallRestMethod(string token)
        {
            string result = string.Empty;
            try
            {
                //set the protocol manually as newer Web Api requires a different protocol
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                var authValue = new AuthenticationHeaderValue("Bearer", token);

                //set the client authorization apikey
                _client = new HttpClient() { DefaultRequestHeaders = { Authorization = authValue } };

                HttpResponseMessage response = await _client.GetAsync(_url).ConfigureAwait(false);
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
