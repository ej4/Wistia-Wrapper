using System.Reflection;
using System.Text;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Extensions;

namespace Wistia
{
    /// <summary>
    /// 
    /// </summary>
    public partial class WistiaRestClient
    {
        public string ApiVersion { get; set; }
        public string BaseUrl { get; set; }
        private string ApiUsername { get; set; }
        private string ApiPassword { get; set; }

        private RestClient _client;

        public WistiaRestClient(string apiPassword)
		{
			ApiVersion = "v1"; 
			BaseUrl = "https://api.wistia.com/";
			ApiUsername = "api";;
			ApiPassword = apiPassword;

			_client = new RestClient();
			_client.Authenticator = new HttpBasicAuthenticator(ApiUsername, ApiPassword);
			_client.BaseUrl = string.Format("{0}{1}", BaseUrl, ApiVersion);

		}

        public T Execute<T>(RestRequest request) where T : new()
        {
            request.OnBeforeDeserialization = (resp) =>
            {
                       
            };

       
            var response = _client.Execute<T>(request);
            return response.Data;
        }

        public RestResponse Execute(RestRequest request)
		{
			return _client.Execute(request);
		}
    }
}
