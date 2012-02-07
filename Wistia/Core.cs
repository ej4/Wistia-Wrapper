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

        /// <summary>
        /// ApiPasswird
        /// </summary>
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
                // for individual resources when there's an error to make
                // sure that RestException props are populated
                if (((int)resp.StatusCode) >= 400)
                {
                    // have to read the bytes so .Content doesn't get populated
                    var content = resp.RawBytes.AsString();
                    var json = JObject.Parse(content);
                    var newJson = new JObject();
                    newJson["RestException"] = json;
                    resp.Content = null;
                    resp.RawBytes = Encoding.UTF8.GetBytes(newJson.ToString());
                }
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
