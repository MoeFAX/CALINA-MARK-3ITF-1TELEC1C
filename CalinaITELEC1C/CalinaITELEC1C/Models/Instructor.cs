namespace CalinaITELEC1C.Models;
using CalinaITELEC1C.Models;
using Microsoft.AspNetCore.Mvc;

    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsTenured { get; set; }
        public DateTime HiringDate { get; set; }
        public Rank InstructorRank { get; set; }

    }

