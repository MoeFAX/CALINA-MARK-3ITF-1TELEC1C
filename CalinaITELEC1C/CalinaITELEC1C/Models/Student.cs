namespace CalinaITELEC1C.Models

{
    public enum Course
    {
        BSIT, BSCS, BSIS, OTHER
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double GPA { get; set; }
        public DateTime AdmissionDate { get; set; }
        public Course StudentCourse { get; set; }
        public string Email { get; set; }
    }
}
