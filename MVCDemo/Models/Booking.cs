namespace MVCDemo.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public DateTime EventDate { get; set; }
        public int Qty { get; set; }
    }
}