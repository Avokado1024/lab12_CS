namespace laboratory_12.Models
{
    public class Timetable
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ServiceId { get; set; }
        public DateTime StartDate { get; set; }
    }
}
