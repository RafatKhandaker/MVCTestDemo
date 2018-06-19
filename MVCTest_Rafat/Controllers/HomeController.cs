using MVCTest.BIL;
using MVCTest.DAL.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCTest_Rafat.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<FundModel> modelList = new DataRetriever().RetrieveAllFunds_Data();
            return View( modelList );
        }

        [HttpPost]
        public ActionResult Index(string search) 
        {
            IEnumerable<FundModel> modelList = new DataRetriever().RetrieveDataBySearch( search );
            return View( modelList );
        }

    }
}