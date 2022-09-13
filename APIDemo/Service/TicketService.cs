using APIDemo.Model;
using System.Xml.Linq;

namespace APIDemo.Service
{
    public class TicketService
    {

        static List<Ticket> Tickets { get; }

        static TicketService()
        {

            Tickets = new List<Ticket>

                {
                    new Ticket { Id = 1, BookedFor="abcd", Price=5000,Qty=200 },
                    new Ticket { Id = 2, BookedFor="Platinum", Price=3000,Qty=300 },
                    new Ticket { Id = 3, BookedFor="Gold", Price=4000,Qty=30 },
                    new Ticket { Id = 4, BookedFor="Silver", Price=2000,Qty=40 },
                    new Ticket { Id = 5, BookedFor="General", Price=800,Qty=10 }
                };
        }

        public static List<Ticket> GetAll() => Tickets;

        public static Ticket? Get(int id)
        {
            Ticket ticket = Tickets.FirstOrDefault(p => p.Id == id);
            return ticket;
        }
    }
}