﻿using IndustrialSafetyLib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.ProductionSafety.Settings
{
    public class ViolationType : Entity
    {
        public string Name { get; set; }
        public ViolationGroup ViolationGroup { get; set; }
    }
}