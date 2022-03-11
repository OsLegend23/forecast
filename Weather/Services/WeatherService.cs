using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Weather.OpenWeatherModels;

namespace Weather.Services
{
    public class WeatherService
    {
        private readonly HttpClient _client;
        private readonly ILogger<WeatherService> _logger;

        public WeatherService(HttpClient client, ILogger<WeatherService> logger)
        {
            _client = client;
            _logger = logger;
        }

        public async Task<WeatherResponse> GetWeatherData(string city)
        {
            try
            {
                //var response = await _client.GetAsync($"/weather?units=metric&q={param}");
                var response = await _client.GetAsync($"weather?q=Mexicali&units=metric&APPID=2d716452512427c5fd5bbfe5262ea00f");
                response.EnsureSuccessStatusCode();
                var responseString = await response.Content.ReadAsStringAsync();
                var responseModel = JsonConvert.DeserializeObject<WeatherResponse>(responseString);
                return responseModel;
            }
            catch (Exception e)
            {
                _logger.LogError("error on api call", e);
                return null;
            }
        }
    }
}
