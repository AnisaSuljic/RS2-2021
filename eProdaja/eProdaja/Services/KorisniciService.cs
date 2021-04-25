using AutoMapper;
using eProdaja.Database;
using eProdaja.Filters;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly eProdajaContext _dbContext;
        protected readonly IMapper _mapper;

        public KorisniciService(eProdajaContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public List<Model.Korisnici> Get(KorisniciSearchRequest request)
        {
            var query = _dbContext.Korisnicis.AsQueryable();
            if(!string.IsNullOrEmpty(request.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Korisnici>>(list);
        }

        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            //throw new NotImplementedException();
            throw new UserException("Ime nije uneseno!");
        }

        //napravljen automapper

        //private Model.Korisnici ToModel(Korisnici entity)
        //{
        //    return new Model.Korisnici()
        //    {
        //        KorisnikId = entity.KorisnikId,
        //        Ime = entity.Ime,
        //        Prezime = entity.Prezime,
        //        KorisnickoIme = entity.KorisnickoIme,
        //        Email = entity.Email,
        //        Telefon = entity.Telefon,
        //        Status = entity.Status
        //    };
        //}
    }
}
