using eProdaja.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodService:IProizvodService
    {
        static List<Proizvod> _proizvodi;

        static ProizvodService()
        {
            _proizvodi = new List<Proizvod>()
            {
                new Proizvod()
                {
                    Id=1,
                    Name="Laptop"
                },
                new Proizvod()
                {
                    Id=2,
                    Name="Miš"
                },
                new Proizvod()
                {
                    Id=3,
                    Name="Tastatura"
                }
            };
        }

        public IEnumerable<Proizvod> Get()
        {
            return _proizvodi;
        }
        public Proizvod GetById(int id)
        {
            return _proizvodi.Where(p => p.Id == id).FirstOrDefault();
        }
        public Proizvod Insert(Proizvod proizvod)
        {
            _proizvodi.Add(proizvod);
            return proizvod;
        }
        public Proizvod Update(int id, Proizvod proizvod)
        {
            var trenutno = _proizvodi.Where(p => p.Id == id).FirstOrDefault();
            trenutno.Name = proizvod.Name;

            return trenutno;
        }
    }
}
