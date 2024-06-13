using IndustrialSafetyLib.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialSafetyLib.Parties
{
    public class Person : Counterparty
    {
        [DisplayName("Имя")]
        public string FirstName { get; set; }
        [DisplayName("Фамилия")]
        public string LastName { get; set; }
        [DisplayName("Отчество")]
        public string MiddleName { get; set; }
        [DisplayName("Гражданство")]
        public Country Citizenship { get; set; }
        [DisplayName("Место рождения")]
        public string BirthPlace { get; set; }
        [DisplayName("Пол")]
        public Sex Sex { get; set; }
        [DisplayName("ФИО")]
        public string ShortName { get; set; }
        [DisplayName("Дата рождения")]
        public DateTime DateOfBirth { get; set; }
    }
}
