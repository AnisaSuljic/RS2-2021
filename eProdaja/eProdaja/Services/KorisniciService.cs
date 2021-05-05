using AutoMapper;
using eProdaja.Database;
using eProdaja.Filters;
using eProdaja.Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
            var entity = _mapper.Map<Database.Korisnici>(request);
            _dbContext.Add(entity);
            if(request.Lozinka!=request.LozinkaPotvrda)
            {
                throw new UserException("Lozinke se ne podudaraju!");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Lozinka);

            _dbContext.SaveChanges();

            foreach (var uloga in request.Uloge)
            {
                Database.KorisniciUloge korisniciUloge = new KorisniciUloge();
                korisniciUloge.KorisnikId = entity.KorisnikId;
                korisniciUloge.UlogaId = uloga;
                korisniciUloge.DatumIzmjene = DateTime.Now;

                _dbContext.KorisniciUloges.Add(korisniciUloge);
            }

            _dbContext.SaveChanges();
            return _mapper.Map<Model.Korisnici>(entity);
        }
        public Model.Korisnici Update(int id, KorisniciUpdateRequest request)
        {
            var entity = _dbContext.Korisnicis.Find(id);
            _mapper.Map(request, entity);

            _dbContext.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
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

        public async Task<eProdaja.Model.Korisnici> Login (string username, string password)
        {
            var entity = await _dbContext.Korisnicis.Include("KorisniciUloges.Uloga").FirstOrDefaultAsync(x => x.KorisnickoIme == username);

            if (entity == null)
                throw new UserException("Pogrešan username ili password");
            var hash = GenerateHash(entity.LozinkaSalt, password);

            if(hash!=entity.LozinkaHash)
                throw new UserException("Pogrešan username ili password");

            return _mapper.Map<eProdaja.Model.Korisnici>(entity);
        }
    }
}
