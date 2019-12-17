using EShop.ApplicationCore.Entities;
using EShop.ApplicationCore.Interfaces;
using EShop.Web.Interfaces;
using EShop.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Web.Services
{
    public class HomeIndexViewModelService : IHomeIndexViewModelService
    {
        private readonly IRepository<Category> _categoryRepository;
        private readonly IRepository<Product> _productRepository;

        public HomeIndexViewModelService(IRepository<Category> categoryRepository, IRepository<Product> productRepository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }


        public HomeIndexViewModel GetIndexViewModel()
        {
            var vm = new HomeIndexViewModel
            {
                Categories = _categoryRepository.GetAll().ToList(),
                Products = _productRepository.GetAll().ToList()
            };

            return vm;
        }
    }
}
