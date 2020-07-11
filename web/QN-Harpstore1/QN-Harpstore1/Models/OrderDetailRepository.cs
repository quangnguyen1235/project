using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace QN_Harpstore1.Models
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly List<OrderDetail> listOrderDetail;

        public OrderDetailRepository()
        {
            listOrderDetail = new List<OrderDetail>();
        }
        
        //private readonly AppDbContext context;

        //public OrderDetailRepository(AppDbContext context)
        //{
        //    this.context = context;
        //}
        //public OrderDetail Create(OrderDetail orderDetail)
        //{
        //    context.OrderDetails.Add(orderDetail);
        //    context.SaveChanges();
        //    return orderDetail;
        //}

        //public bool Delete(string id)
        //{
        //    var delOrderDetail = context.OrderDetails.Find(id);
        //    if (delOrderDetail != null)
        //    {
        //        context.OrderDetails.Remove(delOrderDetail);
        //        return context.SaveChanges() > 0;
        //    }
        //    return false;

        //}

        //public OrderDetail Edit(OrderDetail orderDetail)
        //{
        //    var editOrderDetail = context.OrderDetails.Attach(orderDetail);
        //    editOrderDetail.State = EntityState.Modified;
        //    context.SaveChanges();
        //    return orderDetail;
        //}

        //public OrderDetail Get(string id)
        //{
        //    return context.OrderDetails.Find(id);
        //}

        //public IEnumerable<OrderDetail> Gets(string orderId)
        //{
        //    var data = (from orderDetail in context.OrderDetails
        //                where orderDetail.OrderId == orderId
        //                select orderDetail);
        //    return data;
        //}
        public OrderDetail Create(OrderDetail orderDetail)
        {
            orderDetail.OrderDetailId = $"{Guid.NewGuid()}";
            listOrderDetail.Add(orderDetail);
            return orderDetail;
        }

        public bool Delete(string id)
        {
            var delEmp = Get(id);
            if (delEmp != null)
            {
                listOrderDetail.Remove(delEmp);
                return true;
            }
            return false;
        }

        public OrderDetail Edit(OrderDetail orderDetail)
        {
            throw new NotImplementedException();
        }

        public OrderDetail Get(string id)
        {
            var data = (from lo in listOrderDetail
                        where lo.OrderDetailId == id
                        select lo).FirstOrDefault();
            return data;
        }

        public IEnumerable<OrderDetail> GetAll()
        {
            return listOrderDetail;
        }

        public IEnumerable<OrderDetail> Gets(string orderId)
        {
            return listOrderDetail;
        }
    }
}
