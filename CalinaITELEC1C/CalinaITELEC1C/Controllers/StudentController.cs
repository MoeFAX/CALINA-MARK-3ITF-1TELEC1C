using Microsoft.AspNetCore.Mvc;
using CalinaITELEC1C.Models;
using CalinaITELEC1C.Services;

namespace CalinaITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        private readonly IMyFakeDataService _dummyData;

        public StudentController(IMyFakeDataService dummyData) //constructor
        {
            _dummyData = dummyData;
        }

        public IActionResult Index()
        {
            return View(_dummyData.StudentList);
        }
        public IActionResult ShowDetail(int id)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.StudentId == id);

            if (student != null)
                return View(student);

            return NotFound();
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student newStudent)
        {
            _dummyData.StudentList.Add(newStudent);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.StudentId == id);

            if (student != null)
                return View(student);

            return NotFound();
        }
        [HttpPost]
        public IActionResult UpdateStudent(Student studentChanges)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.StudentId == studentChanges.StudentId);
            if(student != null)
            {
                student.FirstName = studentChanges.FirstName;
                student.LastName = studentChanges.LastName;
                student.Email = studentChanges.Email;   
                student.StudentCourse = studentChanges.StudentCourse;
                student.AdmissionDate = studentChanges.AdmissionDate;
                student.GPA = studentChanges.GPA;
            }
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.StudentId == id);

            if (student != null)
                return View(student);

            return NotFound();
        }

        [HttpPost]
        public IActionResult Delete(Student newStudent)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.StudentId == newStudent.StudentId);
            if (student != null)
                _dummyData.StudentList.Remove(student);

            return RedirectToAction("Index");
        }
    }
        /*
        public IActionResult Index()
        {
            Student st = new Student();
            st.StudentId = 1;
            st.StudentName = "Mark Calina";
            st.DateEnrolled = DateTime.Parse("25/08/2023");
            st.Email = "markgabriel.calina.cics@ust.edu.ph";

            ViewBag.Student = st.StudentId;
            ViewBag.StudentName = st.StudentName;
            ViewBag.StudentCourse = st.StudentCourse;
            ViewBag.Email = st.Email;
            ViewBag.DateEnrolled = st.DateEnrolled;
            return View();
        }
        */
    }

