using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyCompany
{
    public static class AnyCompanyHelpers
    {
        public static class CountryNames
        {
            public static string UK = "UK";
        }

        public static class ConnectionStrings
        {
            public static string AnyCompanyConnectionString = ConfigurationManager.ConnectionStrings["AnyCompanyconnectionString"].ToString();
        }
    }
}