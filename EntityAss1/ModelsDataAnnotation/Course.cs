using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAss1.Models
{
    [Table("Courses")]
    internal class NewCourse
    {
        [Key]
        public  int Crs_Id { get; set; }
        public  int Duration { get; set; }
        [Required]
        [Column("CourseName",TypeName ="varchar")]
        [StringLength(50,MinimumLength =3)]
        public string Name { get; set; }
        public string ?Description { get; set; }
        [Required]
        public  int Top_Id { get; set; }
    }
}
