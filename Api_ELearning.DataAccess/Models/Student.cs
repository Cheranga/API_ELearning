using System;
using System.Collections.Generic;

namespace Api_ELearning.DataAccess.Models
{
    public class Student
    {
        public Student()
        {
            Enrollments = new List<Enrollment>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime? EnrolledDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}