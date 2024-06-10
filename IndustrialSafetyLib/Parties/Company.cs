using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.Parties
{
    public class Company : Counterparty
    {
        public double AverageRating { get; set; }
        public double ProcurementRating { get; set; }
        public double SupplyRating { get; set; }
        public double EquipmentRating { get; set; }

    }
}
