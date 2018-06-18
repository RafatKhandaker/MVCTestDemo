using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTest.DAL.Models
{
    public class FundModel
    {
        private int id;
        private string fundName;
        private string ticket;
        private string morningstar;
        private decimal oneMo;
        private decimal thirdMo;
        private decimal oneYr;
        private decimal fiveYr;
        private decimal inceptionToDate;

        public FundModel() { }

        public FundModel
        (
            int id, string fundName, string ticket, string morningstar, decimal oneMo, decimal thirdMo, decimal oneYr, decimal fiveYr, decimal inceptionToDate
        )
        {
            this.id = id;
            this.fundName = fundName;
            this.ticket = ticket;
            this.morningstar = morningstar;
            this.oneMo = oneMo;
            this.thirdMo = thirdMo;
            this.oneYr = oneYr;
            this.fiveYr = fiveYr;
            this.inceptionToDate = inceptionToDate;
        }

        public int Id { get; set; }
        public string FundName { get; set; }
        public string Ticket { get; set; }
        public string MorningStar { get; set; }
        public decimal OneMo { get; set; }
        public decimal ThirdMo { get; set; }
        public decimal OneYr { get; set; }
        public decimal FiveYr { get; set; }
        public decimal InceptionToDate { get; set; }
    }
}
