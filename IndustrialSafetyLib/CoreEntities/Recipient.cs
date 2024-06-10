using IndustrialSafetyLib.Domain;
using IndustrialSafetyLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.CoreEntities
{
    public abstract class Recipient : Entity
    {
        public string Name { get; set; }
    }
}
