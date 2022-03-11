using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weather.OpenWeatherModels
{
    public partial class Current
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }

        [JsonProperty("weather")]
        public Weather[] Weather { get; set; }
    }
}
