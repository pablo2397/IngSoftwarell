﻿using Entities;

namespace DataAccess
{
    public interface IRepositoryBusiness<T> where T : class, new()
    {
        int Create(T objeto);
        List<T> GetAll();
        int Edit(T objeto);
        int Delete(T objeto);
        TipoVehiculo GetTipoVehiculo(int id);
        Asesor GetAsesor(int id);
        Ciudad GetCiudad(int id);
        Departamento GetDepartamento(int id);
        Vehiculo GetVehiculo(int id);
    }
}
