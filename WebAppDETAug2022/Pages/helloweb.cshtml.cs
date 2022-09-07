using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022.models;
using WebAppDETAug2022.Service;

namespace WebAppDETAug2022.Pages
{
    public class hellowebModel : PageModel
    {
        public string message { get; set; }
        public string Discount { get; set; }
        public void OnGet()
        {
            message = "ASP.Net is Rocking ";
            Discount = "15";

        }
    }
}
