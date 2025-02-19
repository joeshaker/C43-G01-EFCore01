using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAss1.Models
{
    [Table("Std_Courses")]
    internal class NewStd_Course
    {
        [Required]
        public  int Std_Id { get; set; }
        [Required]
        public  int Course_Id { get; set; }
        public  int  Grade { get; set; }
    }
}
