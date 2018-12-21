using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace AnyCompany
{
    public class AnyCompanyTests
    {
        [Test]
       public void SaveZeroAmontOrder()
        {
            //Assume customer 12 is UK
            OrderService orderService = new OrderService();
            Order order = new Order { Amount = 0, OrderId = 1};
            Assert.AreEqual(orderService.PlaceOrder(order, 12), false);
        }

        [Test]
        public void SaveValidAmontOrder()
        {
            OrderService orderService = new OrderService();
            Order order = new Order { Amount = 120.0, OrderId = 1 };
            Assert.AreEqual(orderService.PlaceOrder(order, 12), true);
        }

        [Test]
        public void SaveNullAmontOrder()
        {
            OrderService orderService = new OrderService();
            Order order = null;
            Assert.AreEqual(orderService.PlaceOrder(order, 12), false);
        }
    }
}
