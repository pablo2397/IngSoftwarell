using DataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace Concesionario.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartamentoController : BaseController<Departamento>
    {
        public DepartamentoController(BusinessRules.Common.IRepositoryBusiness<Departamento> repositoryBase) : base(repositoryBase)
        {

        }

        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            Departamento departamento = repositoryBusiness.GetDepartamento(id);
            return base.Delete(departamento);
        }
    }
}
