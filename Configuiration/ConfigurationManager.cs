namespace EducationAndCareerRecommendationsAPI.Configuration
{
    public class ConfigurationManager
    {
        private static ConfigurationManager _instance;
        public static ConfigurationManager Instance => _instance ??= new ConfigurationManager();

        private ConfigurationManager()
        {
            // Initialize configuration settings
        }

        public string GetConfiguration(string key)
        {
            // Return configuration value by key
            return "SampleValue";
        }
    }
}
