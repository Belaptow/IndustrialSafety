using IndustrialSafetyLib.CoreEntities;
using IndustrialSafetyLib.Domain;
using IndustrialSafetyLib.Parties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.Company
{
    public class Employee : Recipient
    {
        public Person Person { get; set; }
        public User? User { get; set; }
        public BusinessUnit? BusinessUnit { get; set; }
        public Department? Department { get; set; }
        public Employee? Manager { get; set; }
        public JobTitle? JobTitle { get; set; }
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
    }
}
