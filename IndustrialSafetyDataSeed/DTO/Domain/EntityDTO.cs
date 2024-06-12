using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyDataSeed.DTO.Domain
{
    public abstract class EntityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
