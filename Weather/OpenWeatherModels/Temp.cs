using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weather.OpenWeatherModels
{
    public partial class Temperature
    {
        [JsonProperty("day")]
        public double Day { get; set; }

        [JsonProperty("min")]
        public double Min { get; set; }

        [JsonProperty("max")]
        public double Max { get; set; }

        [JsonProperty("night")]
        public double Night { get; set; }

        [JsonProperty("eve")]
        public double Eve { get; set; }

        [JsonProperty("morn")]
        public double Morn { get; set; }
    }
}
