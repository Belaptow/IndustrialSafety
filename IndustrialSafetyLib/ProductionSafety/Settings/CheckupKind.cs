﻿using IndustrialSafetyLib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.ProductionSafety.Settings
{
    public class CheckupKind : Entity
    {
        
        public CheckupType Type { get; set; }
    }
}
