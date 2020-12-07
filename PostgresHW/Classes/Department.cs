using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PostgresHW.Classes
{
    [Table("tblDepartment")]
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string name { get; set; }
    }
}
