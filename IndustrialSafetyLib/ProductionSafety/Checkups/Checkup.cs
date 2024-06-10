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
    public class Checkup : Entity
    {
        
        public string Goal { get; set; }
        public CheckupKind Kind { get; set; }
        public int NumberOfViolations { get; set; }
        public DateTime? PlannedDate { get; set; }
        public DateTime? ActualDate { get; set; }
        public PlaceInit Initiator { get; set; }
        public BusinessUnit AuditedBusinessUnit { get; set; }
        public Employee Auditor { get; set; }
        public CheckupDepartments Departments { get; set; }
    }
    public class CheckupDepartment : ChildEntity
    {
        public Department Department { get; set; }
    }
    public class CheckupDepartments : ChildEntityCollectionBase<PlaceInitDepartment> { }
}
