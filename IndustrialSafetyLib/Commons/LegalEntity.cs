using IndustrialSafetyLib.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.Commons
{
    public abstract class LegalEntity : Entity
    {
        [DisplayName("ИНН")]
        public string TIN { get; set; } = "";
        [DisplayName("Город")]
        public City? City { get; set; } = null;
        [DisplayName("Телефон")]
        public string Phone { get; set; } = "";
        [DisplayName("Юр. наименование")]
        public string LegalName { get; set; } = "";
        [DisplayName("Юр. адрес")]
        public string LegalAddress { get; set; } = "";
        [DisplayName("Почтовый адрес")]
        public string PostalAddress { get; set; } = "";
        [DisplayName("Электронная почта")]
        public string Email { get; set; } = "";
    }
}
