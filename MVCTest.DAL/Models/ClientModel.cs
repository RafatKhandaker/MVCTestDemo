using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTest.DAL.Models
{
    public class ClientModel
    {
        private int id;
        private int clientId;
        private int fundId;
        private string firstName;
        private string lastName;
        private string email;

        public ClientModel() { }

        public ClientModel
        (   
            int id,
            int clientId,
            int fundId,
            string firstName,
            string lastName,
            string email
        )
        {
            this.id = id;
            this.clientId = clientId;
            this.fundId = fundId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }

        public int Id() { return this.id; }
        public int ClientId() { return this.clientId; }
        public int FundId() { return this.fundId; }
        public string FirstName() { return this.firstName; }
        public string LastName() { return this.lastName; }
        public string Email() { return this.email; }

        public int sId { get; set; }
        public int sClientId { get; set; }
        public int sFundId { get; set; }
        public string sFirstName { get; set; }
        public string sLastName { get; set; }
        public string sEmail { get; set; }
    }
}
