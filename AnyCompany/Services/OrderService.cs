using System;

namespace AnyCompany
{
    public class OrderService
    {
        private readonly OrderRepository orderRepository = new OrderRepository();

        public bool PlaceOrder(Order order, int customerId)
        {
            try
            {
                Customer customer = CustomerRepository.Load(customerId);

                if (order.Amount == 0)
                    return false;

                if (customer.Country.Equals(AnyCompanyHelpers.CountryNames.UK))
                    order.VAT = 0.2d;
                else
                    order.VAT = 0;

                orderRepository.Save(order);

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
