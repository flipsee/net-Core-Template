using App.Core.Interfaces;
using App.Core.Interfaces.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Helper
{
    public class ModelMapper<TCoreModel, TModelVM> : IModelMapper<TCoreModel, TModelVM> where TCoreModel : IBaseModel where TModelVM : class
    {
        protected readonly IMapper mapper;
        
        public ModelMapper(IMapper mapper)
        {   this.mapper = mapper;
        }
        

        public TCoreModel Map(TModelVM modelVM)
        {
            return mapper.Map<TCoreModel>(modelVM);
        }

        public TModelVM Map(TCoreModel coreModel)
        {
            return mapper.Map<TModelVM>(coreModel);
        }

        public void Map(TModelVM source, TCoreModel destination)
        {
            mapper.Map<TModelVM, TCoreModel>(source, destination); 
        }


        public ICollection<TModelVM> Map(ICollection<TCoreModel> coreModels)
        {
            return mapper.Map<ICollection<TCoreModel>, ICollection<TModelVM>>(coreModels);
        }

        public ICollection<TCoreModel> Map(ICollection<TModelVM> coreModels)
        {
            return mapper.Map<ICollection<TModelVM>, ICollection<TCoreModel>>(coreModels);
        }

        public IList<TModelVM> Map(IList<TCoreModel> coreModels)
        {
            return mapper.Map<IList<TCoreModel>, IList<TModelVM>>(coreModels);
        }

        public IList<TCoreModel> Map(IList<TModelVM> coreModels)
        {
            return mapper.Map<IList<TModelVM>, IList<TCoreModel>>(coreModels);
        }

        public IList<TCoreModel> MapToList(ICollection<TModelVM> coreModels)
        {
            return mapper.Map<ICollection<TModelVM>, IList<TCoreModel>>(coreModels);
        }

        public IList<TModelVM> MapToList(ICollection<TCoreModel> coreModels)
        {
            return mapper.Map<ICollection<TCoreModel>, IList<TModelVM>>(coreModels);
        }
    }
}
