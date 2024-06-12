using IndustrialSafetyLib.Domain;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.Commons
{
    public class Country : Entity
    {
        public string FullName { get; set; }
        public string? Code { get; set; }
    }
}
