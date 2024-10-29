
namespace CorporateWellness.Models
{
    public class UserMeal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Consumption { get; set; }
        public string Calories { get; set; }
        public string Features { get; set; }
        public string Source { get; set; }

        public UserMeal() { }
        public UserMeal(int id, string name, string consumption, string calories, string features, string source)
        {
            Id = id;
            Name = name;
            Consumption = consumption;
            Calories = calories;
            Features = features;
            Source = source;
        }
    }
}
