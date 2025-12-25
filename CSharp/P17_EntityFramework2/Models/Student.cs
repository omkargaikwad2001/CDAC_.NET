using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P17_EntityFramework2.Models
{
    [Table("student")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }   // AUTO_INCREMENT PK

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int Age { get; set; }

        public double Fees { get; set; }
    }
}
