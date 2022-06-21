using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWork.Data.Models;

namespace TestWork.Classes
{
    public class ProductsRepository
    {
        private readonly AppDbContext context;

        public ProductsRepository(AppDbContext context)
        {
            this.context = context;
        }
        //Получение товаров
        public IQueryable<Products> GetProduct()
        {
            return context.products.OrderBy(n => n.Name);
        }
    }
}
