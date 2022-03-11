using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weather.OpenWeatherModels
{
    public class WeatherResponse
    {
        [JsonProperty("lat")]
        public double Latitud { get; set; }

        [JsonProperty("lon")]
        public double Longitud { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timezone_offset")]
        public long TimezoneOffset { get; set; }

        [JsonProperty("current")]
        public Current Current { get; set; }

        [JsonProperty("hourly")]
        public Current[] Hourly { get; set; }

        [JsonProperty("daily")]
        public Daily[] Daily { get; set; }
    }
}
