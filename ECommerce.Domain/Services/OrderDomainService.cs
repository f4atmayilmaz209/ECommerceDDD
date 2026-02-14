using ECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Services
{
    public class OrderDomainService
    {
        public bool CanPlaceOrder(Customer customer,List<OrderItem>items)
        {
            return customer!=null && items!=null && items.Count > 0;
        }
    }
}
