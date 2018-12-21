using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace AnyCompany
{
    internal class OrderRepository
    {
        public void Save(Order order)
        {
            using (var connection = new SqlConnection(AnyCompanyHelpers.ConnectionStrings.AnyCompanyConnectionString))
            {
                //This possibly can be a Stored proc
                string insertQuery = @"INSERT INTO Orders VALUES (@OrderId, @Amount, @VAT)";
                var result = connection.Execute(insertQuery, order);
            }
        }
    }
}