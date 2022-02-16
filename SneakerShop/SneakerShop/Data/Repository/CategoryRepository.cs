using System.Collections.Generic;
using SneakerShop.Data.Interfaces;
using SneakerShop.Data.Models;

namespace SneakerShop.Data.Repository
{
    public class CategoryRepository : ISneakersCategory
    {
        private readonly AppDBContent _appDbContent;
        public CategoryRepository(AppDBContent appDbContent)
        {
            _appDbContent = appDbContent;
        }

        public IEnumerable<Category> AllCategories => _appDbContent.Categories;
    }
}