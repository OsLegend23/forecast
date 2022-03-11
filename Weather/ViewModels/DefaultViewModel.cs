using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using Weather.Services;

namespace Weather.ViewModels
{
	public class DefaultViewModel : MasterPageViewModel
	{
		private readonly WeatherService _weatherService;
		[Required]
		public string city { get; set; }

		public DefaultViewModel(WeatherService weatherService)
		{
			_weatherService = weatherService;
		}

		public async Task GetWeatherInfo()
		{
			var success = await _weatherService.GetWeatherData(city);
		}

	}
}
