using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Model;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VrsteProizvodumController : BaseReadController<VrsteProizvodum,object>
    {
        public VrsteProizvodumController(IVrsteProizvodumService service)
            :base(service)
        {
        }
    }
}
