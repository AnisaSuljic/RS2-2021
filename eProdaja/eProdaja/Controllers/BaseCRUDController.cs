using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    public class BaseCRUDController<T, TSearch, TInsert, TUpdate> : BaseReadController<T, TSearch> where T : class where TSearch : class where TInsert : class where TUpdate : class
    {
        protected readonly ICRUDService<T, TSearch, TInsert, TUpdate> _crudservice;
        public BaseCRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service) 
            : base(service)
        {
            _crudservice = service;
        }
        [HttpPost]
        public T Insert([FromBody]TInsert request)
        {
            return _crudservice.Insert(request);
        }
        [HttpPut("{id}")]
        public T Update(int id,[FromBody] TUpdate request)
        {
            return _crudservice.Update(id,request);
        }
    }
}
