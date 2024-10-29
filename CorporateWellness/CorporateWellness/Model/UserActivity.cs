
namespace CorporateWellness.Models
{
    public class UserActivity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SuggestedSlot { get; set; }
        public string Calories { get; set; }
        public string Features { get; set; }
        public string Source { get; set; }

        public UserActivity() { }
        public UserActivity(int id, string name, string suggestedslot, string calories, string features, string source)
        {
            Id = id;
            Name = name;
            SuggestedSlot = suggestedslot;
            Calories = calories;
            Features = features;
            Source = source;
        }
    }
}
