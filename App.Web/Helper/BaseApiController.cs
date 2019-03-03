using App.Core.Interfaces;
using App.Core.Interfaces.Models;
using App.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace App.Web.Helper
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController<T> : ControllerBase where T : IBaseModel
    {
        protected readonly IBaseService<T> svc;
        
        public BaseApiController(IBaseService<T> svc)
        {
            this.svc = svc;
        }

        // GET: api/Menu
        [HttpGet]
        public virtual IEnumerable<T> Get()
        {
            var result = svc.GetAll().Data;
            return result;
        }

        // GET: api/Menu/5
        [HttpGet("{id}", Name = "Get")]
        public virtual T Get(int id)
        {
            return svc.GetById(id).Data;
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController<TCoreModel, TModelVM> : ControllerBase where TCoreModel : IBaseModel where TModelVM : class
    {
        protected readonly IBaseService<TCoreModel> svc;
        protected readonly IModelMapper<TCoreModel, TModelVM> mapper;

        public BaseApiController(IBaseService<TCoreModel> svc, IModelMapper<TCoreModel, TModelVM> mapper) {
            this.svc = svc;
            this.mapper = mapper;
        }
         
        [HttpGet]
        public virtual IEnumerable<TModelVM> Get()
        {
            var result = mapper.Map(svc.GetAll().Data);
            return result;
        }

        // GET: api/Menu/5
        [HttpGet("{id}", Name = "Get")]
        public virtual TModelVM Get(int id)
        {
            return mapper.Map(svc.GetById(id).Data);
        }
    }
}