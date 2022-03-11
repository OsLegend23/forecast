using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weather.OpenWeatherModels
{
    public partial class Daily
    {
        [JsonProperty("temp")]
        public Temperature Temperature { get; set; }

        [JsonProperty("weather")]
        public Weather[] Weather { get; set; }
    }
}
