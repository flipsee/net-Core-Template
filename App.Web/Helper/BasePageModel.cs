using App.Core.Interfaces;
using App.Core.Interfaces.Models;
using App.Core.Interfaces.Services;
using App.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace App.Web.Helper
{
    public abstract class BasePageModel : PageModel
    {
        [ViewData]
        public List<BreadcrumbVM> Breadcrumbs { get;}
        public bool IsAjaxRequest = false;

        public BasePageModel()
        {
            Breadcrumbs = new List<BreadcrumbVM>(); 
        }

        public void AddBreadcrumbs(BreadcrumbVM breadcrumb)
        {
            Breadcrumbs.Add(breadcrumb);
        }

        public void AddBreadcrumbs(List<BreadcrumbVM> breadcrumbs)
        {
            Breadcrumbs.AddRange(breadcrumbs);
        }

        public override void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            IsAjaxRequest = PageContext.HttpContext.Request.IsAjaxRequest();
        }
    }

    public abstract class BasePageModel<T> : BasePageModel where T : IBaseModel
    {
        protected readonly IBaseService<T> svc;
        
        public BasePageModel(IBaseService<T> svc)
        {
            this.svc = svc; 
        }        
    }

    /// <summary>
    /// this is an extension of the BasePageModel to automate the mapping process between the CoreModel to ViewModel
    /// </summary>
    /// <typeparam name="TCoreModel"></typeparam>
    /// <typeparam name="TModelVM"></typeparam>
    public abstract class BasePageModel<TCoreModel, TModelVM> : BasePageModel<TCoreModel> where TCoreModel : IBaseModel where TModelVM : BaseVM
    {
        protected readonly IModelMapper<TCoreModel, TModelVM> mapper;

        public BasePageModel(IBaseService<TCoreModel> svc, IModelMapper<TCoreModel, TModelVM> mapper) : base(svc)
        {
            this.mapper = mapper;
        }
        
        /// <summary>
        /// VM might have lesser properties than the Core.Model, because of that we need to get the model again frim the service and update/map the VM properties.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        protected TCoreModel ModifyCoreModel(TModelVM entity)
        {
            TCoreModel result = svc.GetById(entity.Id).Data;
            mapper.Map(entity, result);
            return result;
        }
    }
    
}
