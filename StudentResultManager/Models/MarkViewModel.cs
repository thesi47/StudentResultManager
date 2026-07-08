using System.ComponentModel.DataAnnotations;

namespace StudentResultManager.Models
{
    public class MarkViewModel
    {
        [Required]
        public double PhysicsMark { get; set; }
        [Required]
        public double ChemistryMark { get; set; }
        [Required]
        public double MathMark { get; set; }
    }
}
