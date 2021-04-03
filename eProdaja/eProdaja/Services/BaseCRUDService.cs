using AutoMapper;
using eProdaja.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class BaseCRUDService<T, TDb, TSearch, TInsert, TUpdate> : BaseReadService<T, TDb, TSearch>, ICRUDService<T, TSearch, TInsert, TUpdate> where T : class where TSearch : class where TInsert : class where TUpdate : class where TDb : class
    {
        public BaseCRUDService(eProdajaContext dbContext, IMapper mapper) 
            : base(dbContext, mapper)
        {
        }

        public virtual T Insert(TInsert request)
        {
            var set= _dbContext.Set<TDb>();
            TDb entity = _mapper.Map<TDb>(request);
            set.Add(entity);

            _dbContext.SaveChanges();

            return _mapper.Map<T>(entity);
        }

        public virtual T Update(int id, TUpdate request)
        {
            var set= _dbContext.Set<TDb>();
            var entity = set.Find(id);

            _mapper.Map(request, entity);

            _dbContext.SaveChanges();

            return _mapper.Map<T>(entity);
        }
    }
}
