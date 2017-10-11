using System.Collections.Generic;

namespace Api_ELearning.DataAccess.Models
{
    public class Subject
    {
        public Subject()
        {
            Courses = new List<Course>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}