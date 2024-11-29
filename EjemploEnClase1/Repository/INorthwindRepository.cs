using EjemploEnClase.Model;
using Microsoft.AspNetCore.Mvc;

namespace EjemploEnClase.Repository
{
    public interface INorthwindRepository
    {
        Task<List<Employees>> ObtenerTodosLosEmpleados();
        Task<int> ObtenerCantidadEmpleados();
        Task<Employees> EmpleadoPorID(int id);
        Task<Employees> ObtenerEmpleadosPorNombre(string nombreEmpleado);
        Task<Employees?> ObtenerIDEmpleadoPorTitulo(string titulo);
        Task<Employees> ObtenerEmpleadoPorPais(string country);
        Task<List<Employees>> ObtenerTodosLosEmpleadosPorPais(string country);
        Task<Employees> ObtenerElEmpleadoMasGrande();
    }
}