using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApi.Data;
using RestApi.Models;

namespace RestApi.Controllers
{
    [Route("api/cities")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ILogger<CityController> _logger;

        public CityController(ILogger<CityController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var cities = CityDataStore.Cities;
            if(cities.Count == 0)
            {
                _logger.LogInformation($"No city data found");
                return NotFound();
            }
            return Ok(cities);
        }

        [HttpGet("{cityId}")]
        public IActionResult Get(int cityId) 
        {
            var cities = CityDataStore.Cities.FirstOrDefault(c => c.Id.Equals(cityId));
            if(cities == null)
            {
                _logger.LogInformation($"City with Id: {cityId} not found");
                return NotFound();
            }
            return Ok(cities);
        }

        [HttpPut("{cityId}")]
        public IActionResult Put(int cityId, CityDtoEdit city) 
        {
            var cities = CityDataStore.Cities.FirstOrDefault(c => c.Id.Equals(cityId));
            if (cities == null)
            {
                _logger.LogInformation($"City with Id: {cityId} not found");
                return NotFound();
            }
            if(!ModelState.IsValid)
            {
                _logger.LogError(ModelState.ToString());
                return BadRequest(ModelState);
            }
            cities.Name = city.Name;
            cities.Description = city.Description;
            _logger.LogInformation("City has been successfully updated");
            return NoContent();
        }

        [HttpDelete("{cityId}")]
        public IActionResult Delete(int cityId) 
        {
            var cities = CityDataStore.Cities.FirstOrDefault(c => c.Id.Equals(cityId));
            if (cities == null)
            {
                _logger.LogInformation($"City with Id: {cityId} not found");
                return NotFound();
            }
            CityDataStore.Cities.Remove(cities);
            _logger.LogInformation("City has been successfully removed");
            return NoContent();
        }
    }
}
