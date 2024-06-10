using IndustrialSafetyLib.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.Parties
{
    public class Person : Counterparty
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public Country Citizenship { get; set; }
        public string BirthPlace { get; set; }
        public Sex Sex { get; set; }
        public string ShortName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
