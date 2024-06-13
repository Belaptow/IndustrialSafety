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

namespace IndustrialSafety.Pages.Admin.IndSafety.Checkups
{
    public class IndexModel : EntityModel<Checkup>
    {
        public override DbSet<Checkup> DbSet => _context.Checkups;
        public IndexModel(ApplicationDbContext context) : base(context)
        {
        }
    }
}
