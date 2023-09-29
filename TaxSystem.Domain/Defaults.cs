using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxSystem.Domain
{
    public static class Defaults
    {
        private static readonly string _ConnectionString = @"Server = .; Database = TaxSystemDesktop; Trusted_Connection = True;";
        public static string ConnectionString { get { return _ConnectionString; } }
    }
}
