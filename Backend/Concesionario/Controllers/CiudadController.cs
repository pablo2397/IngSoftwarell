using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace Concesionario.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CiudadController : BaseController<Ciudad>
    {
        public CiudadController(BusinessRules.Common.IRepositoryBusiness<Ciudad> repositoryBase) : base(repositoryBase)
        {

        }

        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            Ciudad ciudad = repositoryBusiness.GetCiudad(id);
            return base.Delete(ciudad);
        }
    }
}
