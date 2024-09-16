namespace EducationAndCareerRecommendationsAPI.Models
{
    public class Course
    {
        public int Id { get; set; } // Chave primária
        public string Title { get; set; }
        public string Description { get; set; }
        public string Provider { get; set; }
    }
}
