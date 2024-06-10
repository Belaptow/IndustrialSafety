using IndustrialSafetyLib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.Commons
{
    public class DayOfWeek : Entity
    {
        public int Number {  get; set; }
        public string Name { get; set; }
    }
}
