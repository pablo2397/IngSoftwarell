using Entities;
using Microsoft.AspNetCore.Mvc;

namespace Concesionario.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AsesorController : BaseController<Asesor>
    {
        public AsesorController(BusinessRules.Common.IRepositoryBusiness<Asesor> repositoryBusiness) : base(repositoryBusiness)
        {

        }

        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            Asesor asesor  = repositoryBusiness.GetAsesor(id);
            return base.Delete(asesor);
        }
    }
}
