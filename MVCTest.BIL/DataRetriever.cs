using MVCTest.DAL;
using MVCTest.DAL.Models;
using System.Collections.Generic;


namespace MVCTest.BIL
{
    public class DataRetriever
    {
        public IEnumerable<FundModel> RetrieveAllFunds_Data()
        {
            return new DataAccess().RetrieveAllFunds();
        }

        public IEnumerable<FundModel> RetrieveDataBySearch(string search)
        {
            return new DataAccess().RetrieveDataBySearch(search);
        }
    }
}
