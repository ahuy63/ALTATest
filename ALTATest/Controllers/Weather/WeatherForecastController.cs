using ALTATest.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System.Net.Http.Headers;
using System.Threading;

namespace ALTATest.Controllers.Weather
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private const string URL = "http://api.openweathermap.org/data/2.5/group?id=1580578,1581129,1581297,1581188,1587923&units=metric&appid=91b7466cc755db1a94caf6d86a9c788a";

        public WeatherForecastController()
        {

        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllWeather()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync(URL);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    var a = JsonConvert.DeserializeObject<ResponseViewModel>(data);
                    var b = JsonConvert.DeserializeObject<WeatherDetailViewModel>(data);
                    return Ok(data);
                }
            }

            return BadRequest();
        }
    }
}