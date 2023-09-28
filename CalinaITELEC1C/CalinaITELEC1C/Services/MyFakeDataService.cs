using CalinaITELEC1C.Models;
using CalinaITELEC1C.Services;


namespace CalinaITELEC1C.Services
{
    public class MyFakeDataService : IMyFakeDataService
    {
        public List<Student> StudentList { get; set; }
        public List<Instructor> InstructorsList { get; set; }
        public MyFakeDataService()//constructor 
        {
            StudentList = new List<Student>
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
            InstructorsList = new List<Instructor>
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
        }
    }
}
