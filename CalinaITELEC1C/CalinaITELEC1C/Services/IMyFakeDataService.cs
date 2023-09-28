using CalinaITELEC1C.Models;

namespace CalinaITELEC1C.Services
{
    public interface IMyFakeDataService
    {
        List<Student> StudentList { get; }
        List<Instructor> InstructorsList { get; }
    }
}
