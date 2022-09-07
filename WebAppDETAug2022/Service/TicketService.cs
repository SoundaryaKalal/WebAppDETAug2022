using System.Xml.Linq;
using WebAppDETAug2022.models;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Service
{
    public class TicketService
    {
        static List<Ticket> Tickets { get; }
        static int nextId = 3;
        static TicketService()
        {
            Tickets = new List<Ticket>
                {
                    new Ticket{Id=1, Category="Platinum Plus",Price=5000,MaxLimit=200000 },
                    new Ticket{Id=2,Category="Platinum ",Price=4000,MaxLimit=300000 },
                    new Ticket{Id=3,Category="Gold",Price=3000,MaxLimit=500000},
                    new Ticket{Id=4, Category="Silver",Price=2000,MaxLimit=500000},
                    new Ticket{Id=5,Category="General",Price=5000,MaxLimit=1000000}
                };
        }

        public static List<Ticket> GetAll() => Tickets;

        public static Ticket? Get(int id) => Tickets.FirstOrDefault(p => p.Id == id);

        public static void Add(Ticket ticket)
        {
            ticket.Id = nextId++;
            Tickets.Add(ticket);
        }

        public static void Delete(int id)
        {
            var ticket = Get(id);
            if (ticket is null)
                return;

            Tickets.Remove(ticket);
        }

        public static void Update(Ticket ticket)
        {
            var index = Tickets.FindIndex(p => p.Id == ticket.Id);
            if (index == -1)
                return;

            Tickets[index] = ticket;
        }
    }
}
