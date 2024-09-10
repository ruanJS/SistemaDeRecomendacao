using EducationAndCareerRecommendationsAPI.Data;
using EducationAndCareerRecommendationsAPI.Models;
using EducationAndCareerRecommendationsAPI.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EducationAndCareerRecommendationsAPI.Services
{
    public class RecommendationsService : IRecommendationsService
    {
        private readonly IRecommendationsRepository _repository;

        public RecommendationsService(IRecommendationsRepository repository)
        {
            _repository = repository;
        }

        // Implementação dos métodos para Users
        public IEnumerable<User> GetUsers()
        {
            return _repository.GetUsers();
        }

        public User GetUserById(int id)
        {
            return _repository.GetUserById(id);
        }

        public User CreateUser(User user)
        {
            return _repository.CreateUser(user);
        }

        public bool UpdateUser(User user)
        {
            return _repository.UpdateUser(user);
        }

        public bool DeleteUser(int id)
        {
            return _repository.DeleteUser(id);
        }

        // Implementação dos métodos para Courses
        public IEnumerable<Course> GetCourses()
        {
            return _repository.GetCourses();
        }

        public Course GetCourseById(int id)
        {
            return _repository.GetCourseById(id);
        }

        public Course CreateCourse(Course course)
        {
            return _repository.CreateCourse(course);
        }

        public bool UpdateCourse(Course course)
        {
            return _repository.UpdateCourse(course);
        }

        public bool DeleteCourse(int id)
        {
            return _repository.DeleteCourse(id);
        }

        IEnumerable<User> IRecommendationsService.GetUsers()
        {
            throw new NotImplementedException();
        }

        User IRecommendationsService.GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        User IRecommendationsService.CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        bool IRecommendationsService.UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        bool IRecommendationsService.DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Course> IRecommendationsService.GetCourses()
        {
            throw new NotImplementedException();
        }

        Course IRecommendationsService.GetCourseById(int id)
        {
            throw new NotImplementedException();
        }

        Course IRecommendationsService.CreateCourse(Course course)
        {
            throw new NotImplementedException();
        }

        bool IRecommendationsService.UpdateCourse(Course course)
        {
            throw new NotImplementedException();
        }

        bool IRecommendationsService.DeleteCourse(int id)
        {
            throw new NotImplementedException();
        }

        object IRecommendationsService.GetRecommendations()
        {
            throw new NotImplementedException();
        }
    }
}
