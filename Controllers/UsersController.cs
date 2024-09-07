using EducationAndCareerRecommendationsAPI.Models;
using EducationAndCareerRecommendationsAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EducationAndCareerRecommendationsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IRecommendationsService _recommendationsService;

        public UsersController(IRecommendationsService recommendationsService)
        {
            _recommendationsService = recommendationsService;
        }

        // GET: api/users
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var users = _recommendationsService.GetUsers();
            return Ok(users);
        }

        // GET: api/users/{id}
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = _recommendationsService.GetUserById(id);
            if (user == null)
                return NotFound();

            return Ok(user);
        }

        // POST: api/users
        [HttpPost]
        public ActionResult<User> CreateUser([FromBody] User user)
        {
            var createdUser = _recommendationsService.CreateUser(user);
            return CreatedAtAction(nameof(GetUser), new { id = createdUser.Id }, createdUser);
        }

        // PUT: api/users/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] User user)
        {
            if (id != user.Id)
                return BadRequest();

            var updated = _recommendationsService.UpdateUser(user);
            if (!updated)
                return NotFound();

            return NoContent();
        }

        // DELETE: api/users/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var deleted = _recommendationsService.DeleteUser(id);
            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}
