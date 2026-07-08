using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentResultManager.Data;
using StudentResultManager.Entities;
using StudentResultManager.Models;

namespace StudentResultManager.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.students.ToListAsync());
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(StudentViewModel model)
        {
            if(ModelState.IsValid) return View(model);

            Student student = new Student
            {
                Name = model.Name,
                Roll = model.Roll,
                RegistrationDate = DateTime.Now
            };

            _context.students.Add(student);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateMark()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateMark(MarkViewModel model)
        {
            if (ModelState.IsValid) return View(model);
            Mark mark = new Mark
            {
                MathMark = model.MathMark,
                ChemistryMark = model.ChemistryMark,
                PhysicsMark = model.PhysicsMark
            }; 
            return RedirectToAction("Index");
        }
       
    }
}
