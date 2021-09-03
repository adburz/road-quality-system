namespace RoadQualitySystem.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using RoadQualitySystem.Database;
    using RoadQualitySystem.Models;
    using System.Linq;

    [Route("api/[controller]")]
    [ApiController]
    public class RoadQualityController : ControllerBase
    {
        private readonly RoadQualitiesContext _db;
        public RoadQualityController(RoadQualitiesContext roadQualitiesDb)
        {
            _db = roadQualitiesDb;
        }

        [HttpPost("/addCoordinate")]
        public IActionResult AddCoordinate(RoadQualityRequest coordinateRequest)
        {
            if (coordinateRequest == null) {
                return BadRequest();
            }

            _db.RoadQualities.Add(new RoadQuality()
            {
                Id = System.Guid.NewGuid(),
                Longtitude = coordinateRequest.Longtitude,
                Latitude = coordinateRequest.Latitude,
                Score = coordinateRequest.Score
            });
            _db.SaveChanges();

            return Ok();
        }

        [HttpGet("/getCoordinates")]
        public IActionResult GetCoordinates()
        {
            return Ok(_db.RoadQualities.ToList());
        }
    }
}
