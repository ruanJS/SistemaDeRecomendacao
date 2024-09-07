namespace EducationAndCareerRecommendationsAPI.Models
{
    public class User
    {
        public int Id { get; set; } // Chave primária
        public string Name { get; set; }
        public string Email { get; set; }
        public string CareerGoal { get; set; }
    }
}
