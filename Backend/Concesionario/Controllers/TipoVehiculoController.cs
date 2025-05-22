using Entities;
using Microsoft.AspNetCore.Mvc;

namespace Concesionario.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoVehiculoController : BaseController<TipoVehiculo>
    {
        public TipoVehiculoController(BusinessRules.Common.IRepositoryBusiness<TipoVehiculo> repositoryBase) : base(repositoryBase)
        {

        }

        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            TipoVehiculo tipoVehiculo = repositoryBusiness.GetTipoVehiculo(id);
            return base.Delete(tipoVehiculo);
        }
    }
}
