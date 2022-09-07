using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Pages
{
    public class IPLEventModel : PageModel
    {
        public List<Ticket> Tickets { get; set; }

        public void OnGet()
        {
            Tickets = new List<Ticket>
            {
                new Ticket {Category="PlatinumPlus", Price=5000, MaxLimit=200000 },
                new Ticket {Category="Platinum", Price=4000, MaxLimit=300000 },
                new Ticket {Category="Gold", Price=3000, MaxLimit=500000 },
                new Ticket {Category="Silver", Price=2000, MaxLimit=500000 },
                new Ticket {Category="General", Price=800, MaxLimit=100000 }
            };
        }
    }
}