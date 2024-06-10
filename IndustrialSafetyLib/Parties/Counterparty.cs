using IndustrialSafetyLib.Commons;
using IndustrialSafetyLib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.Parties
{
    public abstract class Counterparty : LegalEntity
    {
        public string Name { get; set; }
        public string PSRN { get; set; }
        public string NCEO { get; set; }
        public string NCEA { get; set; }
        public string Note { get; set; }
        public bool NonResident { get; set; }
    }
}
