using IndustrialSafetyLib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.CoreEntities
{
    public abstract class Group : Recipient
    {
        List<Recipient> Members { get; set; } = new List<Recipient>();
    }
}
