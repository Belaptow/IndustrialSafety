using IndustrialSafetyLib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.Commons
{
    public abstract class LegalEntity : Entity
    {
        public string TIN { get; set; } = "";
        public City? City { get; set; } = null;
        public string Phone { get; set; } = "";
        public string LegalName { get; set; } = "";
        public string LegalAddress { get; set; } = "";
        public string PostalAddress { get; set; } = "";
        public string Email { get; set; } = "";
    }
}
