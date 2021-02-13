using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTS
{
    public class Employee
    {

        public int id { get; set; }
        public int roleId { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string passwordHash { get; set; }
        public DateTime registeredAt  { get; set; }
        public DateTime lastLogin { get; set; }
        public string intro { get; set; }
        public string profile { get; set; }

       
    }
}