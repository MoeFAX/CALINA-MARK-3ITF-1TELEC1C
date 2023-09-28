using Microsoft.AspNetCore.Mvc;
using CalinaITELEC1C.Models;
using CalinaITELEC1C.Services;

namespace CalinaITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IMyFakeDataService _dummyData;

        public InstructorController(IMyFakeDataService dummyData) //constructor
        {
            _dummyData = dummyData;
        }

            public IActionResult Index()
            {
                return View(_dummyData.InstructorsList);
            }
            public IActionResult ShowDetail(int id)
            {
                Instructor? instructor = _dummyData.InstructorsList.FirstOrDefault(st => st.InstructorId == id);

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
                _dummyData.InstructorsList.Add(newInstructor);
                return RedirectToAction("Index");
        }
            [HttpGet]
            public IActionResult UpdateInstructor(int id)
            {
                Instructor? instructor = _dummyData.InstructorsList.FirstOrDefault(st => st.InstructorId == id);

                if (instructor != null)
                    return View(instructor);

                return NotFound();
            }
            [HttpPost]
            public IActionResult UpdateInstructor(Instructor InstructorChanges)
            {
                Instructor? instructor = _dummyData.InstructorsList.FirstOrDefault(st => st.InstructorId == InstructorChanges.InstructorId);
                if (instructor != null)
                {
                    instructor.FirstName = InstructorChanges.FirstName;
                    instructor.LastName = InstructorChanges.LastName;
                    instructor.InstructorRank = InstructorChanges.InstructorRank;
                    instructor.HiringDate = InstructorChanges.HiringDate;
                    instructor.IsTenured = InstructorChanges.IsTenured;
                }
                return RedirectToAction("Index");
        }

            [HttpGet]
            public IActionResult Delete(int id)
            {
                Instructor? instructor = _dummyData.InstructorsList.FirstOrDefault(st => st.InstructorId == id);

                if (instructor != null)
                    return View(instructor);

                return NotFound();
            }

            [HttpPost]
            public IActionResult Delete(Instructor InstructorDelete)
            {
                Instructor? instructor = _dummyData.InstructorsList.FirstOrDefault(st => st.InstructorId == InstructorDelete.InstructorId);
                if (instructor != null)
                    _dummyData.InstructorsList.Remove(instructor);

                return RedirectToAction("Index");
        }
    }
}
