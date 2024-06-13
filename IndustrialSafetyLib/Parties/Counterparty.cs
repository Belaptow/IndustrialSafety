using IndustrialSafetyLib.Commons;
using IndustrialSafetyLib.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.Parties
{
    public abstract class Counterparty : LegalEntity
    {
        [DisplayName("ОГРН")]
        public string PSRN { get; set; }
        [DisplayName("NCEO")]
        public string NCEO { get; set; }
        [DisplayName("NCEA")]
        public string NCEA { get; set; }
        [DisplayName("Примечание")]
        public string Note { get; set; }
        [DisplayName("Не резидент")]
        public bool NonResident { get; set; }
    }
}
