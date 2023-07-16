using System;
using System.ComponentModel;

namespace FluentValidation.Models
{
    public class Person
    {
        [DisplayName("Staff person name")]
        public string Name { get; set; }

        [DisplayName("Staff person lastname")]
        public string Lastname { get; set; }

        [DisplayName("Staff person phone number")]
        public string Phone { get; set; }

        [DisplayName("Staff person access level to system")]
        public int AccessLevel { get; set; }

        [DisplayName("Staff person salary")]
        public decimal Salary { get; set; }
    }
}
