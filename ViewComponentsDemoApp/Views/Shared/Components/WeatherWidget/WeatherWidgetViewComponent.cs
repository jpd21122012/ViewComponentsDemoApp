using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentsDemoApp.Models;

namespace ViewComponentsDemoApp.Views.Shared.Components.WeatherWidget
{
    public class WeatherWidgetViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string cityName)
        {
            var response = await GetWeatherInfo(cityName);
            return View("Default", response);
        }

        private async Task<WeatherInfo> GetWeatherInfo(string cityName)
        {

            var obj = new WeatherInfo();
            obj.City = cityName;
            obj.Date = DateTime.Now.ToString("dddd h:mm tt");

            if (cityName == "London")
            {
                obj.Icon = "cloudy.jpg";
                obj.Condition = "Cloudy";
                obj.Precipitation = "7%";
                obj.Humidity = "70%";
                obj.Wind = "6 km/h";
            }
            else if (cityName == "New York")
            {
                obj.Icon = "partly_cloudy.png";
                obj.Condition = "Partly Cloudy";
                obj.Precipitation = "17%";
                obj.Humidity = "80%";
                obj.Wind = "16 km/h";
            }
            else if (cityName == "Paris")
            {
                obj.Icon = "rain.png";
                obj.Condition = "Rain";
                obj.Precipitation = "67%";
                obj.Humidity = "20%";
                obj.Wind = "9 km/h";
            }

            return obj;
        }
    }
}