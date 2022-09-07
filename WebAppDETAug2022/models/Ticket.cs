using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string? Category { get; set; }
        public int Price { get; set; }
        public int MaxLimit { get; set; }
    }
}
