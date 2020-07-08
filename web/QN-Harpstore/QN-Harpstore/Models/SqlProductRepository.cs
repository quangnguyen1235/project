using Microsoft.EntityFrameworkCore;
using QN_Harpstore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace QN_Harpstore.Models
{
    public class SqlProductRepository : IProductRepository
    {
        public Product Create(Product product)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Product Edit(Product product)
        {
            throw new NotImplementedException();
        }

        public ProductDetailViewModel Get(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Gets()
        {
            throw new NotImplementedException();
        }

        //private readonly AppDbContext appDbContext;

        //public SqlProductRepository(AppDbContext appDbContext)
        //{
        //    this.appDbContext = appDbContext;
        //}
        //public Product Create(Product product)
        //{
        //    appDbContext.Products.Add(product);
        //    appDbContext.SaveChanges();
        //    return product;
        //}

        //public bool Delete(string id)
        //{
        //    var delEmp = appDbContext.Products.Find(id);
        //    if (delEmp != null)
        //    {
        //        appDbContext.Products.Remove(delEmp);
        //        return appDbContext.SaveChanges() > 0;
        //    }
        //    return false;
        //}

        //public Product Edit(Product product)
        //{
        //    var editEmp = appDbContext.Products.Attach(product);
        //    editEmp.State = EntityState.Modified;
        //    appDbContext.SaveChanges();
        //    return product;
        //}

        //public ProductDetailViewModel Get(string id)
        //{
        //    throw new NotImplementedException();
        //}

        //public ProductDetailViewModel Get(string id)
        //{
        //    var data = (from products in appDbContext.Products
        //                join productType in appDbContext.ProductTypes
        //                on products.ProductTypeId equals productType.ProductTypeId
        //                join producer in appDbContext.Producers
        //                on products.ProducerId equals producer.ProducerId
        //                where products.ProductId == id
        //                select new ProductDetailViewModel()
        //                {
        //                    ProductId = products.ProductId,
        //                    ProductAvatar = products.ProductAvatar,
        //                    ProducerId = producer.ProducerId,
        //                    ProductProducerName = producer.ProducerName,
        //                    ProductTypeId = productType.ProductTypeId,
        //                    _ProductTypeName = productType.ProductTypeName,
        //                    ProductName = products.ProductName,
        //                    ProductPrice = products.ProductPrice,
        //                    FullDescription = products.FullDescription,
        //                    ShortDescription = products.ShortDescription,
        //                    IsUsed = products.IsUsed,
        //                }).FirstOrDefault();
        //    return data;
        //}
        //public IEnumerable<Product> Gets()
        //{
        //    return appDbContext.Products;
        //}
    }
}
