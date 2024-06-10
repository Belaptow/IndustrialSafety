using IndustrialSafetyLib.Domain;
using IndustrialSafetyLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.CoreEntities
{
    
    public abstract class ChildEntityCollectionBase<T> : List<T>, IChildEntityCollection<T> where T : ChildEntity
    {
        public T AddNew()
        {
            return default(T);
        }

        public void Remove(ChildEntity entity)
        {
            this.Remove(entity);
        }
    }
}
