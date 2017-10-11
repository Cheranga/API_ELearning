using System;
using System.Linq;
using Api_ELearning.DataAccess.Models;

namespace Api_ELearning.DataAccess.Repositories
{
    public class LearningRepository : ILearningRepository
    {
        public IQueryable<Subject> GetAllSubjects()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Course> GetAllCourses()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Tutor> GetAllTutors()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Student> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Enrollment> GetAllEnrollments()
        {
            throw new NotImplementedException();
        }

        public Subject GetSubject(int id)
        {
            throw new NotImplementedException();
        }

        public Course GetCourse(int id)
        {
            throw new NotImplementedException();
        }

        public Tutor GetTutor(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public bool AddSubject(Subject subject)
        {
            throw new NotImplementedException();
        }

        public bool AddCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public bool AddTutor(Tutor tutor)
        {
            throw new NotImplementedException();
        }

        public bool AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public bool EnrollStudent(Enrollment enrollment)
        {
            throw new NotImplementedException();
        }
    }
}