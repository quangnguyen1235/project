using QN_Harpstore1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore1.ViewModels
{
    public class OrderDetailViewModel : OrderDetail
    {
        public ProductDetailViewModel Product { get; set; }
        public float CalculateMoney()
        {
            return OrderDetailMoney = Product.ProductPrice * OrderDetailQlt;
        }
    }
}
