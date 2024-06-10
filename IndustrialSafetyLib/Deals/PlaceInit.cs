using IndustrialSafetyLib.Company;
using IndustrialSafetyLib.CoreEntities;
using IndustrialSafetyLib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.Deals
{
    public class PlaceInit : Entity
    {
        public string Name { get; set; }
        public PlaceInitDepartments Departments { get; set; }
        public PlaceInitBusinessUnits BusinessUnits { get; set; }
    }
    public class PlaceInitDepartment : ChildEntity
    {
        public Department Department { get; set; }
    }
    public class PlaceInitDepartments : ChildEntityCollectionBase<PlaceInitDepartment> { }
    public class PlaceInitBusinessUnit : ChildEntity
    {
        public BusinessUnit BusinessUnit { get; set; }
    }
    public class PlaceInitBusinessUnits : ChildEntityCollectionBase<PlaceInitBusinessUnit> { }
}
