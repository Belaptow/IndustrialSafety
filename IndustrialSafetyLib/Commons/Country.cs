﻿using IndustrialSafetyLib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.Commons
{
    public class Country : Entity
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
