using IndustrialSafetyLib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.Commons
{
    public class City : Entity
    {
        public string Name { get; set; }
        public Country Country { get; set; }
    }
}
