using System.ComponentModel.DataAnnotations;

namespace StudentResultManager.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter a Roll Number...")]
        public int Roll { get; set; }
        public DateTime? RegistrationDate { get; set; }
        [Required]
        public double PhysicsMark { get; set; }
        [Required]
        public double ChemistryMark { get; set; }
        [Required]
        public double MathMark { get; set; }
    }
}
