using App.Core.Interfaces;
using App.Core.Interfaces.Models;
using App.Core.Interfaces.Services;
using App.Web.ViewModel;

namespace App.Web.Helper
{
    public class BasePageModelWithUpdate<T> : BasePageModel<T> where T : IBaseModelWithUpdate
    {
        new protected readonly IBaseServiceWithUpdate<T> svc;

        public BasePageModelWithUpdate(IBaseServiceWithUpdate<T> svc): base(svc)
        {
            this.svc = svc;
        }
    }

    public class BasePageModelWithUpdate<TCoreModel, TModelVM> : BasePageModel<TCoreModel, TModelVM> where TCoreModel : IBaseModelWithUpdate where TModelVM : BaseVM
    {
        new protected readonly IBaseServiceWithUpdate<TCoreModel> svc;

        public BasePageModelWithUpdate(IBaseServiceWithUpdate<TCoreModel> svc, IModelMapper<TCoreModel, TModelVM> mapper) : base(svc, mapper)
        {
            this.svc = svc;
        }

    }
}
