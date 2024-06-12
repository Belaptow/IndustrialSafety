using IndustrialSafetyLib.Domain;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.Commons
{
    public class Country : Entity
    {
        [DisplayName("Полное наименование")]
        public string FullName { get; set; }
        [DisplayName("Код")]
        public string? Code { get; set; }
    }
}
