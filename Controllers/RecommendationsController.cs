using Microsoft.AspNetCore.Mvc;
using EducationAndCareerRecommendationsAPI.Services;

namespace EducationAndCareerRecommendationsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecommendationsController : ControllerBase
    {
        private readonly IRecommendationsService _service;

        public RecommendationsController(IRecommendationsService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetRecommendations()
        {
            var recommendations = _service.GetRecommendations();
            return Ok(recommendations);
        }
    }
}
