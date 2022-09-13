using APIDemo.Model;
using APIDemo.Service;
using Microsoft.AspNetCore.Mvc;

namespace APIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        [Route("all")]

        public List<Ticket> Get()
        {
            return TicketService.GetAll();
        }

            [HttpGet]
            [Route("{id}")]
            public Ticket Get(int id)
            {
                Ticket t = TicketService.Get(id);
                 return t;
            }

        }
    }


