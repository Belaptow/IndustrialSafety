using IndustrialSafetyLib.Commons;
using IndustrialSafetyLib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.Company
{
    public class BusinessUnit : LegalEntity
    {
        public string Name { get; set; }
        public string Description { get; set; } = "";
        public string TRRC { get; set; } = "";
        public BusinessUnit? HeadCompany {  get; set; } 
        public Employee? CEO { get; set; }
    }
}
