using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Database;
using eProdaja.Model.Requests;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;
        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Model.Korisnici> Get([FromQuery] KorisniciSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpPost]
        public Model.Korisnici Insert([FromBody]KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }
    }
}
