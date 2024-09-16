using EducationAndCareerRecommendationsAPI.Data;
using EducationAndCareerRecommendationsAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EducationAndCareerRecommendationsAPI.Repositories
{
    public class RecommendationsRepository : IRecommendationsRepository
    {
        private readonly ApplicationDbContext _context;

        public RecommendationsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Implementação dos métodos para Usuários
        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return _context.Users.Find(id);
        }

        public User CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public bool UpdateUser(User user)
        {
            User existingUser = _context.Users.Find(user.Id);
            if (existingUser == null)
                return false;

            existingUser.Name = user.Name;
            existingUser.Email = user.Email;
            existingUser.CareerGoal = user.CareerGoal;

            _context.SaveChanges();
            return true;
        }

        public bool DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
                return false;

            _context.Users.Remove(user);
            _context.SaveChanges();
            return true;
        }

        // Implementação dos métodos para Cursos
        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses.ToList();
        }

        public Course GetCourseById(int id)
        {
            return _context.Courses.Find(id);
        }

        public Course CreateCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
            return course;
        }

        public bool UpdateCourse(Course course)
        {
            var existingCourse = _context.Courses.Find(course.Id);
            if (existingCourse == null)
                return false;

            existingCourse.Title = course.Title;
            existingCourse.Description = course.Description;
            existingCourse.Provider = course.Provider;

            _context.SaveChanges();
            return true;
        }

        public bool DeleteCourse(int id)
        {
            var course = _context.Courses.Find(id);
            if (course == null)
                return false;

            _context.Courses.Remove(course);
            _context.SaveChanges();
            return true;
        }
    }
}
