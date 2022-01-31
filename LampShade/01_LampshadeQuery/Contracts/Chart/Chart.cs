using System.Collections.Generic;
using Newtonsoft.Json;

namespace _01_LampshadeQuery.Contracts.Chart
{
    public class Chart
    {
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        [JsonProperty(PropertyName = "data")]
        public List<int> Data { get; set; }

        [JsonProperty(PropertyName = "backgroundColor")]
        public List<string> BackgroundColor { get; set; }

        [JsonProperty(PropertyName = "borderColor")]
        public string BorderColor { get; set; }


    }
}