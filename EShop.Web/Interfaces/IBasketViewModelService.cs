using EShop.ApplicationCore.Entities;
using EShop.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Web.Interfaces
{
    public interface IBasketViewModelService
    {
        void AddToBasket(int productId, int quantity = 1);

        void RemoveFromBasket(int productId);


        IReadOnlyCollection<BasketItem> GetBasketItems();

        int TotalItems();

        HeaderCartViewModel GetHeaderCartViewModel();

    }
}
