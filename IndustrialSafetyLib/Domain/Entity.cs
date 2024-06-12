using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace IndustrialSafetyLib.Domain
{
    public abstract class Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Ид")]
        public int Id { get; set; }
        [DisplayName("Наименование")]
        public string Name { get; set; }
        public virtual string DisplayValue { get => Name; }
        
        public override string ToString()
        {
            return DisplayValue;
        }
    }
}
