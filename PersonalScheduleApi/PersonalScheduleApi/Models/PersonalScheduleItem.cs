namespace PersonalScheduleApi.Models
{
    public class PersonalScheduleItem
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }

        public bool IsComplete { get; set; }
    }
}
