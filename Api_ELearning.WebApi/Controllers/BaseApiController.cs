using System.Web.Http;
using Api_ELearning.DataAccess.Repositories;

namespace Api_ELearning.WebApi.Controllers
{
    public class BaseApiController : ApiController
    {
        protected readonly ILearningRepository LearningRepository;

        public BaseApiController(ILearningRepository learningRepository)
        {
            LearningRepository = learningRepository;
        }
    }
}