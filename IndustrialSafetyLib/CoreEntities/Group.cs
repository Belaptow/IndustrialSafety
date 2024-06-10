using IndustrialSafetyLib.Domain;
using IndustrialSafetyLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.CoreEntities
{
    public abstract class Group : Recipient
    {
        public virtual GroupMembers Members { get; set; }
    }
    public class GroupMembers : ChildEntityCollectionBase<GroupMember>
    {

    }
    public abstract class GroupMember : ChildEntity
    {
        public virtual Recipient? Member { get; set; }
    }
}
