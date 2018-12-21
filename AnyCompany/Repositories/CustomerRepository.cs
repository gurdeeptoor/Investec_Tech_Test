using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace AnyCompany
{
    public static class CustomerRepository
    {
        public static Customer Load(int customerId)
        {
            using (var connection = new SqlConnection(AnyCompanyHelpers.ConnectionStrings.AnyCompanyConnectionString))
            {
                //This possibly can be a Stored proc
                return connection.Query<Customer>(string.Format("Select * FROM CUSTOMERS Where CustomerId ={0}", customerId)).First();
            }
        }
    }
}
