using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApi.Data;
using RestApi.Models;

namespace RestApi.Controllers
{
    [Route("api/cities/{cityId}/pointofinterest")]
    [ApiController]
    public class InterestController : ControllerBase
    {
        private readonly ILogger<InterestController> _logger;

        public InterestController(ILogger<InterestController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{interestId}", Name = "GetCityInterest")]
        public IActionResult Get(int cityId, int interestId)
        {
            var cities = CityDataStore.Cities.FirstOrDefault(c => c.Id == cityId);
            if (cities == null) 
            {
                _logger.LogInformation("city not found");
                return NotFound();
            }
            var cityInterest = cities.Interests.FirstOrDefault(c => c.Id == interestId);
            if (cityInterest == null)
            {
                _logger.LogInformation("city interest not found");
                return NotFound();
            }
            return Ok(cityInterest);
        }


        [HttpPost]
        public IActionResult Post(int cityId, InterestDtoEdit interest)
        {
            var cities = CityDataStore.Cities.FirstOrDefault(c => c.Id == cityId);
            if (cities == null)
            {
                _logger.LogInformation("city not found");
                return NotFound();
            }
           
            if (!ModelState.IsValid)
            {
                _logger.LogCritical(ModelState.ToString());
                return BadRequest(ModelState);
            }
            var maxInterest = CityDataStore.Cities.SelectMany(c => c.Interests).Max(p => p.Id);
            var newInterst = new InterestDto()
            {
                Id = maxInterest++,
                Name = interest.Name,
                Description = interest.Description,
            };

            cities.Interests.Add(newInterst);

            return CreatedAtRoute("GetCityInterest", new
            {
                cityId = cities.Id,
                interestId = newInterst.Id
            }, newInterst); ;
        }


        [HttpPut("{interestId}")]
        public IActionResult Put(int cityId, int interestId, InterestDtoEdit interest)
        {
            var cities = CityDataStore.Cities.FirstOrDefault(c => c.Id == cityId);
            if (cities == null)
            {
                _logger.LogInformation("city not found");
                return NotFound();
            }
            var cityInterest = cities.Interests.FirstOrDefault(c => c.Id == interestId);
            if (cityInterest == null)
            {
                _logger.LogInformation("city interest not found");
                return NotFound();
            }
            if(!ModelState.IsValid) {
                _logger.LogCritical(ModelState.ToString());
                return BadRequest(ModelState);
            }

            cityInterest.Name = interest.Name;
            cityInterest.Description = interest.Description;

            return NoContent();
        }

        [HttpDelete("{interestId}")]
        public IActionResult Delete(int cityId, int interestId)
        {
            var cities = CityDataStore.Cities.FirstOrDefault(c => c.Id == cityId);
            if (cities == null)
            {
                _logger.LogInformation("city not found");
                return NotFound();
            }
            var cityInterest = cities.Interests.FirstOrDefault(c => c.Id == interestId);
            if (cityInterest == null)
            {
                _logger.LogInformation("city interest not found");
                return NotFound();
            }
            cities.Interests.Remove(cityInterest);
            return NoContent();
        }
    }
}
