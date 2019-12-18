using EShop.ApplicationCore.Entities;
using EShop.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Web.Interfaces
{
    public interface IHomeIndexViewModelService
    {
        HomeIndexViewModel GetHomeIndexViewModel(int? categoryId, int pageIndex, int productsPerPage);

    }
}
