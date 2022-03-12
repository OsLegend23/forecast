using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using Weather.Models;
using Weather.Services;

namespace Weather.ViewModels
{
	public class DefaultViewModel : MasterPageViewModel
	{
		private readonly WeatherService _weatherService;

		public SearchCity SearchCity { get; set; }
		public City City { get; set; }

		public DefaultViewModel(WeatherService weatherService)
		{
			_weatherService = weatherService;
		}

		public async Task GetWeatherInfo()
		{
			var success = await _weatherService.GetWeatherData("Mexicali");

			City = new City
			{
				TempMin = success.Daily[0].Temperature.Min,
				TempMax = success.Daily[0].Temperature.Max,
				Icon = success.Daily[0].Weather[0].Icon,
			};
		}

	}
}
