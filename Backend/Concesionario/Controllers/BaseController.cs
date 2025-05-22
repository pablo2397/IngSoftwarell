using BusinessRules.Common;
using DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace Concesionario.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController<T> : ControllerBase where T : class, new()
    {
        
        public BusinessRules.Common.IRepositoryBusiness<T> repositoryBusiness;
        public BaseController(BusinessRules.Common.IRepositoryBusiness<T> repositoryBusiness)
        {
            this.repositoryBusiness = repositoryBusiness;
        }

        [HttpPost("Create")]
        public int Create(T objeto)
        {
            return repositoryBusiness.Create(objeto);
        }

        [HttpGet("GetAll")]
        public List<T> GetAll()
        {
            return repositoryBusiness.GetAll();
        }

        [HttpPut("Edit")]
        public int Edit(T objeto)
        {
            return repositoryBusiness.Edit(objeto);
        }
        protected int Delete(T objeto)
        {
            return repositoryBusiness.Delete(objeto);
        }
    }
}
