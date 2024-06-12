using IndustrialSafetyLib.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.Commons
{
    public class Region : Entity
    {
        [DisplayName("Страна")]
        public Country Country { get; set; }
        [DisplayName("Код")]
        public string Code { get; set; }
    }
}
