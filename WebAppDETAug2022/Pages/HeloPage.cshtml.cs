using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022.Service;

namespace WebAppDETAug2022.Pages
{
    public class HeloPageModel : PageModel
    {
      
            public IHelo ob { get; set; }

            public string Message { get; set; }

            public HeloPageModel(IHelo i)
            {
                ob = i;
            }
            public void OnGet()
            {
                //ob = new Helo2();
                Message = ob.SayHelo("sonu");
            }
     
    }
}
