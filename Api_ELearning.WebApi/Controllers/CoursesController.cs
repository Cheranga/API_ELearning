using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Api_ELearning.DataAccess.Repositories;

namespace Api_ELearning.WebApi.Controllers
{
    [RoutePrefix("api/courses")]
    public class CoursesController : BaseApiController
    {
        public CoursesController(ILearningRepository learningRepository) : base(learningRepository)
        {
        }

        [Route("")]
        public IHttpActionResult GetAll()
        {
            var courses = LearningRepository.GetAllCourses().Select(x=>new {x.Id, x.Name});
            return Ok(courses);
        }

        [Route("{courseId:int}")]
        public IHttpActionResult GetCourse(int courseId)
        {
            var course = LearningRepository.GetCourse(courseId);
            if (course == null)
            {
                return NotFound();
            }

            return Ok(new
            {
                course.Id,
                course.Name
            });
        }

        
    }
}