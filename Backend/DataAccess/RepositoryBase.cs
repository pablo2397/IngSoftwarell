using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class RepositoryBase<T> : IRepositoryBusiness<T> where T : class, new()
    {
        public ConcesionarioContext concesionarioContext;
        public RepositoryBase(ConcesionarioContext concesionarioContext)
        {
            this.concesionarioContext = concesionarioContext;
        }
        public int Create(T objeto)
        {
            int respuesta = 0;
            try
            {
                concesionarioContext.Add(objeto);
                return concesionarioContext.SaveChanges();
            }catch (Exception)
            {
                return respuesta;
            }
        }
        public List<T> GetAll()
        {
            return concesionarioContext.Set<T>().ToList();
        }
        public int Edit(T objeto)
        {
            int respuesta = 0;
            try
            {
                concesionarioContext.Update(objeto);
                return concesionarioContext.SaveChanges();
            }
            catch (Exception)
            {
                return respuesta;
            }
        }
        public int Delete(T objeto)
        {
            concesionarioContext.Remove(objeto);
            return concesionarioContext.SaveChanges();
        }
        public TipoVehiculo GetTipoVehiculo(int id)
        {
            return concesionarioContext.TipoVehiculos.Find(id)!;
        }
        public Asesor GetAsesor(int id)
        {
            return concesionarioContext.Asesores.Find(id)!;
        }
        public Ciudad GetCiudad(int id)
        {
            return concesionarioContext.Ciudades.Find(id)!;
        }
        public Departamento GetDepartamento(int id)
        {
            return concesionarioContext.Departamentos.Find(id)!;
        }
        public Vehiculo GetVehiculo(int id)
        {
            return concesionarioContext.Vehiculos.Find(id)!;
        }
    }
}
