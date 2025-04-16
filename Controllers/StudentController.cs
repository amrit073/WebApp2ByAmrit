using Microsoft.AspNetCore.Mvc;
using WebApp2ByAmrit.Models;

namespace WebApp2ByAmrit.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentRepository _repo;

        public StudentController(StudentRepository repo) => _repo = repo;

        public IActionResult MyRazorPage()
        {
            int rollNumber = 42;
            return View(new { Name = "Amrit", RollNumber = rollNumber, MultiplicationNumber = rollNumber + 1 });
        }

        public IActionResult Create() => View();

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (!ModelState.IsValid) return View(student);
            
            _repo.AddStudent(student);
            return RedirectToAction(nameof(Details), new { id = student.StdID });
        }

        public IActionResult Details(int id) => 
            _repo.GetStudent(id) is Student student 
                ? View(student) 
                : NotFound();
    }
} 