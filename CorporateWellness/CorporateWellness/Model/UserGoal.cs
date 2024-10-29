
namespace CorporateWellness.Models
{
    public class UserGoal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Frequency { get; set; }
        public string Measurement { get; set; }
        public string Support { get; set; }
        public string Status { get; set; }

        public UserGoal() { }
        public UserGoal(int id, string name, string frequency, string measurement, string support, string status)
        {
            Id = id;
            Name = name;
            Frequency = frequency;
            Measurement = measurement;
            Support = support;
            Status = status;
        }
    }
}
