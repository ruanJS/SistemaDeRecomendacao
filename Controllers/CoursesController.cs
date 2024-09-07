using EducationAndCareerRecommendationsAPI.Models;
using EducationAndCareerRecommendationsAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EducationAndCareerRecommendationsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly IRecommendationsService _recommendationsService;

        public CoursesController(IRecommendationsService recommendationsService)
        {
            _recommendationsService = recommendationsService;
        }

        // GET: api/courses
        [HttpGet]
        public ActionResult<IEnumerable<Course>> GetCourses()
        {
            var courses = _recommendationsService.GetCourses();
            return Ok(courses);
        }

        // GET: api/courses/{id}
        [HttpGet("{id}")]
        public ActionResult<Course> GetCourse(int id)
        {
            var course = _recommendationsService.GetCourseById(id);
            if (course == null)
                return NotFound();

            return Ok(course);
        }

        // POST: api/courses
        [HttpPost]
        public ActionResult<Course> CreateCourse([FromBody] Course course)
        {
            var createdCourse = _recommendationsService.CreateCourse(course);
            return CreatedAtAction(nameof(GetCourse), new { id = createdCourse.Id }, createdCourse);
        }

        // PUT: api/courses/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateCourse(int id, [FromBody] Course course)
        {
            if (id != course.Id)
                return BadRequest();

            var updated = _recommendationsService.UpdateCourse(course);
            if (!updated)
                return NotFound();

            return NoContent();
        }

        // DELETE: api/courses/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteCourse(int id)
        {
            var deleted = _recommendationsService.DeleteCourse(id);
            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}
