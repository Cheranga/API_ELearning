using System.Collections.Generic;

namespace Api_ELearning.DataAccess.Models
{
    public class Course
    {
        public Course()
        {
            Tutor = new Tutor();
            Subject = new Subject();
            Enrollments = new List<Enrollment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public int TutorId { get; set; }
        public Tutor Tutor { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}