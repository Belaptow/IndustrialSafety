using IndustrialSafetyLib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.Commons
{
    public class Region : Entity
    {
        public string Name { get; set; }
        public Country Country { get; set; }
        public string Code { get; set; }
    }
}
