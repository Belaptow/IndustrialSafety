using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.Domain
{
    public abstract class Entity
    {
        public string Name { get; set; }
        public virtual string DisplayValue { get => Name; }
        public int Id { get; set; }
        public override string ToString()
        {
            return DisplayValue;
        }
    }
}
