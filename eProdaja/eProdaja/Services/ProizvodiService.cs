using AutoMapper;
using eProdaja.Database;
using eProdaja.Model;
using eProdaja.Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodiService : BaseCRUDService<Model.Proizvodi,Database.Proizvodi,Model.ProizvodiSearchObject,ProizvodiInsertRequest,ProizvodiUpdateRequest>,IProizvodiService
    {
        public ProizvodiService(eProdajaContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }
        public override IEnumerable<Model.Proizvodi> Get(ProizvodiSearchObject search = null)
        {
            var entity = _dbContext.Set<Database.Proizvodi>().AsQueryable();

            if(!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.Naziv));
            }
            if(search.JedinicaMjereId.HasValue)
            {
                entity = entity.Where(x => x.JedinicaMjereId == search.JedinicaMjereId);
            }
            if (search.VrstaId.HasValue)
            {
                entity = entity.Where(x => x.VrstaId == search.VrstaId);
            }
            if (search?.IncludeJedinicaMjere==true)
            {
                entity = entity.Include(x=>x.JedinicaMjere);
            }
            //zbog starije verzije c# koristim ovaj if da ne pada ako ne unesemo nista 
            //inace ne treba ako se koristi verzija 8.0

            if(search.IncludeListJedinicaMjere!=null)
            {
                if (search?.IncludeListJedinicaMjere.Length>0)
                {
                    foreach (var item in search.IncludeListJedinicaMjere)
                    {
                        entity = entity.Include(item);
                    }
                }
            }

            var list = entity?.ToList();
            return _mapper.Map<List<Model.Proizvodi>>(list);
        }
    }
}
