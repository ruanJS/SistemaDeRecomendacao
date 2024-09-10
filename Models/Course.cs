namespace EducationAndCareerRecommendationsAPI.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public object Title { get; internal set; }
        public object Provider { get; internal set; }
    }

}