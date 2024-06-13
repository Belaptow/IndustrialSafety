using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IndustrialSafety.Data;
using IndustrialSafetyLib.Commons;
using IndustrialSafetyLib.Domain;
using SharedLib;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Reflection;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Globalization;
using IndustrialSafety.Domain.ViewModel;
using IndustrialSafetyLib.ProductionSafety.Checkups;
using IndustrialSafetyLib.Parties;

namespace IndustrialSafety.Pages.Admin.Parties.People
{
    public class IndexModel : EntityModel<Person>
    {
        public override DbSet<Person> DbSet => _context.People;
        public IndexModel(ApplicationDbContext context) : base(context)
        {
        }
    }
}
