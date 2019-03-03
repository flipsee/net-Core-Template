using App.Core.Interfaces.Models;
using System.Collections.Generic;

namespace App.Core.Interfaces
{
    public interface IModelMapper<TCoreModel, TModelVM> where TCoreModel : IBaseModel where TModelVM : class
    {
        TCoreModel Map(TModelVM modelVM);

        TModelVM Map(TCoreModel coreModel);

        void Map(TModelVM source, TCoreModel destination);


        ICollection<TModelVM> Map(ICollection<TCoreModel> coreModels);

        IList<TModelVM> Map(IList<TCoreModel> coreModels);

        ICollection<TCoreModel> Map(ICollection<TModelVM> coreModels);

        IList<TCoreModel> Map(IList<TModelVM> coreModels);

        IList<TCoreModel> MapToList(ICollection<TModelVM> coreModels);
        IList<TModelVM> MapToList(ICollection<TCoreModel> coreModels);

    }
}
