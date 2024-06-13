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
using IndustrialSafetyLib.Company;

namespace IndustrialSafety.Pages.Admin.Company.Employees
{
    public class IndexModel : EntityModel<Employee>
    {
        public override DbSet<Employee> DbSet => _context.Employees;
        public IndexModel(ApplicationDbContext context) : base(context)
        {
        }
    }
}
