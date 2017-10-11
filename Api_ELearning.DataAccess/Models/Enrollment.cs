using System;

namespace Api_ELearning.DataAccess.Models
{
    public class Enrollment
    {
        public Enrollment()
        {
            Course = new Course();
            Student = new Student();
        }

        public int Id { get; set; }
        public DateTime EnrolledDate { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}