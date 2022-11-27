namespace WebAPI.Data
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Details { get; set; }
        public DateOnly ProductionYear { get; set; }
    }
}
