using AutoMapper;
using eProdaja.Database;
using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class JediniceMjereService : BaseReadService<Model.JediniceMjere,Database.JediniceMjere,object>, IJediniceMjereService
    {

        public JediniceMjereService(eProdajaContext dbContext, IMapper mapper)
            :base(dbContext,mapper)
        {
            
        }
       
    }
}
