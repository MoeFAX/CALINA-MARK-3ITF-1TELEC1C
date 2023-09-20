using Microsoft.AspNetCore.Mvc;
using CalinaITELEC1C.Models;
namespace CalinaITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        
            List<Instructor> InstructorsList = new List<Instructor>
            {
                new Instructor()
                {
                    FirstName= "Gabriel", LastName= "Montano", InstructorRank = Rank.Professor, HiringDate = DateTime.Now, IsTenured= false, InstructorId=1
                },
                new Instructor()
                {
                    FirstName= "Ron", LastName= "Antonio", InstructorRank = Rank.AssociateProfessor, HiringDate = DateTime.Now, IsTenured= false, InstructorId=2
                },
                new Instructor()
                {
                    FirstName= "Jeanny", LastName= "Garcia", InstructorRank = Rank.AssistantProfessor, HiringDate = DateTime.Now, IsTenured= true, InstructorId=3
                }

            };
            public IActionResult Index()
            {
                return View(InstructorsList);
            }
            public IActionResult ShowDetail(int id)
            {
                Instructor? instructor = InstructorsList.FirstOrDefault(st => st.InstructorId == id);

                if(instructor != null)
                    return View(instructor);
            
                return NotFound();
            }
            [HttpGet]
            public IActionResult AddInstructor()
            {
                return View();
            }
            [HttpPost]
            public IActionResult AddInstructor(Instructor newInstructor)
            {
                InstructorsList.Add(newInstructor);
                return View("Index", InstructorsList);
            }
            [HttpGet]
            public IActionResult UpdateInstructor(int id)
            {
                Instructor? instructor = InstructorsList.FirstOrDefault(st => st.InstructorId == id);

                if (instructor != null)
                    return View(instructor);

                return NotFound();
            }
            [HttpPost]
            public IActionResult UpdateInstructor(Instructor InstructorChanges)
            {
                Instructor? instructor = InstructorsList.FirstOrDefault(st => st.InstructorId == InstructorChanges.InstructorId);
                if (instructor != null)
                {
                    instructor.FirstName = InstructorChanges.FirstName;
                    instructor.LastName = InstructorChanges.LastName;
                    instructor.InstructorRank = InstructorChanges.InstructorRank;
                    instructor.HiringDate = InstructorChanges.HiringDate;
                    instructor.IsTenured = InstructorChanges.IsTenured;
                }
                return View("Index", InstructorsList);
            }
    }
}
