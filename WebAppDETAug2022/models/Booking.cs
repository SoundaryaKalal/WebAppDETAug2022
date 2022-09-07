namespace WebAppDETAug2022.models
{
    public class Booking
    {
        public int Id { get; set; }
        public string Event { get; set; }
        public DateTime BookingDate { get; set; }

        public int Qty { get; set; }    
    }
}
