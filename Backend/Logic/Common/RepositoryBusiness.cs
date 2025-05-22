using Entities;

namespace BusinessRules
{
    public class RepositoryBusiness<T> : Common.IRepositoryBusiness<T> where T : class, new()
    {
        public DataAccess.IRepositoryBusiness<T> repositoryBase;

        public RepositoryBusiness(DataAccess.IRepositoryBusiness<T> repositoryBase)
        {
            this.repositoryBase = repositoryBase;
        }
        public int Create(T objeto)
        {
            return repositoryBase.Create(objeto);
        }
        public List<T> GetAll()
        {
            return repositoryBase.GetAll();
        }
        public int Edit(T objeto)
        {
            return repositoryBase.Edit(objeto);
        }
        public int Delete(T objeto)
        {
            return repositoryBase.Delete(objeto);
        }
        public Asesor GetAsesor(int id)
        {
            return repositoryBase.GetAsesor(id);
        }
        public TipoVehiculo GetTipoVehiculo(int id)
        {
            return repositoryBase.GetTipoVehiculo(id);
        }
        public Ciudad GetCiudad(int id)
        {
            return repositoryBase.GetCiudad(id);
        }
        public Departamento GetDepartamento(int id)
        {
            return repositoryBase.GetDepartamento(id);
        }
        public Vehiculo GetVehiculo(int id)
        {
            return repositoryBase.GetVehiculo(id);
        }
    }
}
