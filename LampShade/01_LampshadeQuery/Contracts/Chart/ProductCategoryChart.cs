using System.Collections.Generic;
using Newtonsoft.Json;

namespace _01_LampshadeQuery.Contracts.Chart
{
    public class ProductCategoryChart : Chart
    {
        [JsonProperty(PropertyName = "labels")]
        public List<string> Labels { get; set; }
    }
}
