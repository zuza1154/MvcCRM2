using System;
using System.ComponentModel.DataAnnotations;


namespace MvcCRM.Models
{
    public class User
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string Login { get; set; }
    }
}
