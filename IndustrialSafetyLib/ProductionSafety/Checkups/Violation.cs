using IndustrialSafetyLib.Company;
using IndustrialSafetyLib.CoreEntities;
using IndustrialSafetyLib.Deals;
using IndustrialSafetyLib.Domain;
using IndustrialSafetyLib.ProductionSafety.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.ProductionSafety.Checkups
{
    public class Violation : Entity
    {
        public string Name { get; set; }
        public Employee? Author { get; set; }
        public Department? Department { get; set; }
        public DateTime Date {  get; set; }
        public ViolationKind Kind { get; set; }
        public Checkup Checkup { get; set; }
    }
    public class ViolationResponsible : ChildEntity
    {
        public Employee? Responsible { get; set; }
        public DateTime CorrectionTerm { get; set; }
        public string CorrectionMeasure { get; set; }
        public string Verification { get; set; }
    }
    public class ViolationResponsibles : ChildEntityCollectionBase<ViolationResponsible> { }
}
