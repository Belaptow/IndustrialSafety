using IndustrialSafetyLib.Company;
using IndustrialSafetyLib.CoreEntities;
using IndustrialSafetyLib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.ProductionSafety.Settings
{
    public class CheckupType : Entity
    {
        public string Name { get; set; }
        public CheckupTypeNotificationSettings NotificationSettings { get; set; }
        public CheckupNotififedBusinessUnit BusinessUnit { get; set; }
    }
    public class CheckupNotififedBusinessUnit : ChildEntity
    {
        public BusinessUnit BusinessUnit { get; set; }
    }
    public class CheckupNotififedBusinessUnits : ChildEntityCollectionBase<CheckupNotififedBusinessUnit>
    {

    }
    public class CheckupTypeNotificationSetting : ChildEntity
    {
        public DayOfWeek DayOfWeek { get; set; }
    }
    public class CheckupTypeNotificationSettings : ChildEntityCollectionBase<CheckupTypeNotificationSetting>
    {

    }
}
