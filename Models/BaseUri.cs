using Newtonsoft.Json;

namespace api_teste_adobe.Models
{
    class BaseUri
    {
        [JsonProperty("apiAccessPoint")]
        public string ApiAcessPoint { get; set; }

        [JsonProperty("WebAccessPoint")]
        public string WebAcessPoint { get; set; }
    }
}
