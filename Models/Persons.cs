using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employeemanagement.Models
{
    public partial class Persons
    {
        [Column("PersonID")]
        public int? PersonId { get; set; }
        [StringLength(255)]
        public string LastName { get; set; }
        [StringLength(255)]
        public string FirstName { get; set; }
        [Column("phno")]
        [StringLength(255)]
        public string Phno { get; set; }
        [StringLength(255)]
        public string City { get; set; }
        public int Age { get; set; }
       
    }
}

