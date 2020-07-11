using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using QN_Harpstore1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore1.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext context;

        public ProductRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Product Create(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return product;
        }

        public bool Delete(string id)
        {
            var delEmp = context.Products.Find(id);
            if (delEmp != null)
            {
                context.Products.Remove(delEmp);
                return context.SaveChanges() > 0;
            }
            return false;
        }

        public Product Edit(Product product)
        {
            var editEmp = context.Products.Attach(product);
            editEmp.State = EntityState.Modified;
            context.SaveChanges();
            return product;
        }

        public ProductDetailViewModel Get(string id)
        {
            var data = (from product in context.Products
                        join protype in context.Protypes
                        on product.ProductTypeId equals protype.ProTypeId
                        join producer in context.Producers
                        on product.ProducerId equals producer.ProducerId
                        where product.ProductId == id
                        select new ProductDetailViewModel()
                        {
                            ProductId = product.ProductId,
                            ProductAvatar = product.ProductAvatar,
                            ProducerId = producer.ProducerId,
                            ProductProducerName = producer.ProducerName,
                            ProductTypeId = protype.ProTypeId,
                            ProductTypeName = protype.ProductTypeName,
                            ProductName = product.ProductName,
                            ProductPrice = product.ProductPrice,
                            FullDescription = product.FullDescription,
                            ShortDescription = product.ShortDescription,
                        }).FirstOrDefault();
            return data;
        }

        public IEnumerable<Product> Gets()
        {
            var data = (from product in context.Products
                        join protype in context.Protypes
                        on product.ProductTypeId equals protype.ProTypeId
                        join producer in context.Producers
                        on product.ProducerId equals producer.ProducerId
                        select new Product
                        {
                            ProductId = product.ProductId,
                            ProductAvatar = product.ProductAvatar,
                            ProducerId = producer.ProducerId,
                            ProductProducer = producer,
                            ProductTypeId = protype.ProTypeId,
                            ProductType = protype,
                            ProductName = product.ProductName,
                            ProductPrice = product.ProductPrice,
                            FullDescription = product.FullDescription,
                            ShortDescription = product.ShortDescription,
                        }
                        );
            return data;
        }

        public IEnumerable<Product> GetsToProducer(int? id)
        {

            var data = (from p in context.Products
                        where p.ProducerId == id
                        select p);
                        //select new Product
                        //{
                        //    ProductId = p.ProductId,
                        //    ProductAvatar = p.ProductAvatar,
                        //    ProductName = p.ProductName,
                        //    ProductPrice = p.ProductPrice,
                        //    ProducerId = p.ProducerId,
                        //    ProductTypeId = p.ProductTypeId,
                        //    FullDescription = p.FullDescription
                        //});
            return data;
        }

        public IEnumerable<Product> GetsToProType(int? id)
        {
            var data = (from p in context.Products
                        where p.ProductTypeId == id
                        select p);
                        //select new Product
                        //{
                        //    ProductId = p.ProductId,
                        //    ProductAvatar = p.ProductAvatar,
                        //    ProductName = p.ProductName,
                        //    ProductPrice = p.ProductPrice,
                        //    ProducerId = p.ProducerId,
                        //    ProductTypeId = p.ProductTypeId,
                        //    FullDescription = p.FullDescription
                        //});
            return data;
        }

        public Product GetToOrderDetail(string id)
        {
            return context.Products.Find(id);
        }
    }
}
