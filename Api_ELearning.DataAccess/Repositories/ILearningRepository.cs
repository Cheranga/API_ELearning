using System.Linq;
using Api_ELearning.DataAccess.Models;

namespace Api_ELearning.DataAccess.Repositories
{
    public interface ILearningRepository
    {
        IQueryable<Subject> GetAllSubjects();
        IQueryable<Course> GetAllCourses();
        IQueryable<Tutor> GetAllTutors();
        IQueryable<Student> GetAllStudents();
        IQueryable<Enrollment> GetAllEnrollments();

        Subject GetSubject(int id);
        Course GetCourse(int id);
        Tutor GetTutor(int id);
        Student GetStudent(int id);

        bool AddSubject(Subject subject);
        bool AddCourse(Course course);
        bool AddTutor(Tutor tutor);
        bool AddStudent(Student student);
        bool EnrollStudent(Enrollment enrollment);
    }
}