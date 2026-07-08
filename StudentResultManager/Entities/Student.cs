using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace StudentResultManager.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Roll { get; set; }
        public DateTime RegistrationDate { get; set; }
 
    }
}
