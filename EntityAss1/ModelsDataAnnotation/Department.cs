﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAss1.Models
{
    [Table("Departments")]
    internal class NewDepartment
    {
        [Key]
        public  int DeptId { get; set; }
        [Required]
        [Column("DeptName", TypeName = "varchar")]
        [StringLength(50, MinimumLength = 3)]
        public  string Name { get; set; }
        [Required]
        public int Ins_Id { get; set; }
        public  DateTime Hiring_Date { get; set; }

    }
}
