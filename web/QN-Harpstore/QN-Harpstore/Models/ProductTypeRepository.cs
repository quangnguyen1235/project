using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore.Models
{
    public class ProductTypeRepository : IProductTypeRepository
    {
        private readonly AppDbContext appDbContext;

        public ProductTypeRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<ProductType> Gets()
        {
            throw new NotImplementedException();
        }
        //public IEnumerable<ProductType> Gets()
        //{
        //    return appDbContext.ProductTypes;
        //}
    }
}
