using IndustrialSafetyLib.CoreEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.Interfaces
{
    public interface IChildEntityCollection<out T> : IEnumerable<T> where T : ChildEntity
    {
        T AddNew();
        void Remove(ChildEntity entity);
    }
}
