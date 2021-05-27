using System.Collections.Generic;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class CategotyRepository : ICarsCategory
    {
        private readonly AppDBContent appDbContent;

        public CategotyRepository(AppDBContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<Category> AllCategories => appDbContent.Categories;
    }
}