using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace MVCTest_Rafat.DAL
{
    public class DataAccess
    {
        private string conn_String;

        public DataAccess(string ConnString) { this.conn_String = ConnString; }

        public DataSet RetrieveAllFunds() { return null; }
 
    }
}
