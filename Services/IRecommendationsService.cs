using EducationAndCareerRecommendationsAPI.Models;
using System.Collections.Generic;

namespace EducationAndCareerRecommendationsAPI.Services
{
    public interface IRecommendationsService
    {
        // Métodos para Users
        IEnumerable<User> GetUsers();
        User GetUserById(int id);
        User CreateUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(int id);

        // Métodos para Courses
        IEnumerable<Course> GetCourses();
        Course GetCourseById(int id);
        Course CreateCourse(Course course);
        bool UpdateCourse(Course course);
        bool DeleteCourse(int id);
        object GetRecommendations();
    }
}
