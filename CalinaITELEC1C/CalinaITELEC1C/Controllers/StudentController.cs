using Microsoft.AspNetCore.Mvc;
using CalinaITELEC1C.Models;
namespace CalinaITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>
        {
            new Student()
            {
                 FirstName= "Mark Gabriel", LastName= "Calina", GPA = 1.50, AdmissionDate = DateTime.Now, StudentCourse=Course.BSIT, Email= "markgabriel.calina.cics@ust.edu.ph", StudentId=1
            },
            new Student()
            {
                 FirstName= "Kanye", LastName= "West", GPA = 2.75, AdmissionDate = DateTime.Now, StudentCourse=Course.BSCS, Email= "kanye.west.cics@ust.edu.ph", StudentId=2
            },
            new Student()
            {
                 FirstName= "Taylor", LastName= "Swift", GPA = 2.00, AdmissionDate = DateTime.Now, StudentCourse=Course.BSIS, Email= "taylor.swift.cics@ust.edu.ph", StudentId=3
            }
        };

        public IActionResult Index()
        {
            return View(StudentList);
        }
        public IActionResult ShowDetail(int id)
        {
            Student? student = StudentList.FirstOrDefault(st => st.StudentId == id);

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
            StudentList.Add(newStudent);
            return View("Index", StudentList);
        }

        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            Student? student = StudentList.FirstOrDefault(st => st.StudentId == id);

            if (student != null)
                return View(student);

            return NotFound();
        }
        [HttpPost]
        public IActionResult UpdateStudent(Student studentChanges)
        {
            Student? student = StudentList.FirstOrDefault(st => st.StudentId == studentChanges.StudentId);
            if(student != null)
            {
                student.FirstName = studentChanges.FirstName;
                student.LastName = studentChanges.LastName;
                student.Email = studentChanges.Email;   
                student.StudentCourse = studentChanges.StudentCourse;
                student.AdmissionDate = studentChanges.AdmissionDate;
                student.GPA = studentChanges.GPA;
            }
            return View("Index", StudentList);
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

