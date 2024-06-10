using IndustrialSafetyLib.CoreEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.Company
{
    public class Department : CoreEntities.Group
    {
        public BusinessUnit BusinessUnit { get; set; }
        public Employee? Manager { get; set; }
        public Department? HeadOffice { get; set; }
        public string Code { get; set; }
    }
}
