using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using IndustrialSafetyLib.Domain;
using Microsoft.EntityFrameworkCore;
using SharedLib;

namespace IndustrialSafety.Domain.ViewModel
{
    public abstract class EntityModel<T> : PageModel where T : Entity
    {
        protected readonly IndustrialSafety.Data.ApplicationDbContext _context;
        public readonly PropertyInfo[] Properties;
        public abstract DbSet<T> DbSet { get; }
        public IList<T> Entities { get; set; } = default!;
        public EntityModel(IndustrialSafety.Data.ApplicationDbContext context) 
        {
            _context = context;
            Properties = typeof(T).GetProperties().Where(prop => prop.Name != "DisplayValue").ToArray();
        }
        public string GetDisplayName(PropertyInfo property)
        {
            var attrName = GetAttributeDisplayName(property);
            if (!string.IsNullOrEmpty(attrName))
                return attrName;

            var metaName = GetMetaDisplayName(property);
            if (!string.IsNullOrEmpty(metaName))
                return metaName;

            return property.Name.ToString(CultureInfo.InvariantCulture);
        }
        public object GetPropertyValue(T item, PropertyInfo property)
        {
            if (item == null || property == null) return null;
            return property.GetValue(item);
        }
        public string GetPropertyDisplayValue(T item, PropertyInfo property)
        {
            return GetPropertyValue(item, property)?.ToString() ?? "";
        }
        private string GetAttributeDisplayName(PropertyInfo property)
        {
            var atts = property.GetCustomAttributes(
                typeof(DisplayNameAttribute), true);
            if (atts.Length == 0)
                return null;
            var displayNameAttribute = atts[0] as DisplayNameAttribute;
            return displayNameAttribute != null ? displayNameAttribute.DisplayName : null;
        }

        private string GetMetaDisplayName(PropertyInfo property)
        {
            if (property.DeclaringType != null)
            {
                var atts = property.DeclaringType.GetCustomAttributes(
                    typeof(MetadataTypeAttribute), true);
                if (atts.Length == 0)
                    return null;

                var metaAttr = atts[0] as MetadataTypeAttribute;
                if (metaAttr != null)
                {
                    var metaProperty =
                        metaAttr.MetadataClassType.GetProperty(property.Name);
                    return metaProperty == null ? null : GetAttributeDisplayName(metaProperty);
                }
            }
            return null;
        }
        protected virtual IQueryable<T> GetQuery(DbSet<T> set)
        {
            return set.AsNoTracking();
        }
        protected virtual IQueryable<T> PrepareQuery(IQueryable<T> query)
        {
            typeof(T)
                .GetProperties()
                .Where(prop => typeof(Entity).IsAssignableFrom(prop.PropertyType))
                .ForEach(prop => query = query.Include(prop.Name));
            return query;
        }
        public virtual async Task OnGetAsync()
        {
            Entities = await PrepareQuery(GetQuery(DbSet)).ToListAsync();
        }
    }
}
