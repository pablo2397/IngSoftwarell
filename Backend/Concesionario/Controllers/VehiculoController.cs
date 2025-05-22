using Entities;
using Microsoft.AspNetCore.Mvc;

namespace Concesionario.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehiculoController : BaseController<Vehiculo>
    {
        public VehiculoController(BusinessRules.Common.IRepositoryBusiness<Vehiculo> repositoryBase) : base(repositoryBase)
        {
            
        }

        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            Vehiculo vehiculo = repositoryBusiness.GetVehiculo(id);
            return base.Delete(vehiculo);
        }
    }
}