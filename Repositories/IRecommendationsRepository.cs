using EducationAndCareerRecommendationsAPI.Models;
using System.Collections.Generic;

namespace EducationAndCareerRecommendationsAPI.Repositories
{
    public interface IRecommendationsRepository
    {
        // Métodos para Usuários
        IEnumerable<User> GetUsers();
        User GetUserById(int id);
        User CreateUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(int id);

        // Métodos para Cursos
        IEnumerable<Course> GetCourses();
        Course GetCourseById(int id);
        Course CreateCourse(Course course);
        bool UpdateCourse(Course course);
        bool DeleteCourse(int id);
    }
}
