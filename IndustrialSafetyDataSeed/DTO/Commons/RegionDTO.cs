using IndustrialSafetyDataSeed.DTO.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyDataSeed.DTO.Commons
{
    public class RegionDTO : EntityDTO
    {
        public string Code {  get; set; }
        public string Country { get; set; }
    }
}
