using EjemploEnClase.Model;
using EjemploEnClase.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjemploEnClase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NorthwindController : ControllerBase
    {
        private readonly INorthwindRepository _repository;

        public NorthwindController(INorthwindRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("api/TodosLosEmpleados")]
        public async Task<List<Employees>> ObtenerTodosLosEmpleados()
        {
            return await _repository.ObtenerTodosLosEmpleados();
        }

        [HttpGet]
        [Route("api/CantidadEmpleados")]
        public async Task<int> ObtenerCantidadEmpleados()
        {
            return await _repository.ObtenerCantidadEmpleados();
        }
        [HttpGet]
        [Route("api/EmpleadoPorID")]
        public async Task<Employees> EmpleadoPorID([FromQuery] int empleadoID)
        {
            return await _repository.EmpleadoPorID(empleadoID);
        }
        [HttpGet]
        [Route("api/EmpleadosPorNombre")]
        public async Task<Employees> ObtenerEmpleadosPorNombre([FromQuery] string nombreEmpleado)
        {
            return await _repository.ObtenerEmpleadosPorNombre(nombreEmpleado);
        }
        [HttpGet]
        [Route("api/IDempleadoPorTitulo")]
        public async Task<Employees> ObtenerIDEmpleadoPorTitulo([FromQuery] string titulo)
        {
            return await _repository.ObtenerIDEmpleadoPorTitulo(titulo);
        }
        [HttpGet]
        [Route("api/EmpleadoporPais")]
        public async Task<Employees> ObtenerEmpleadoPorPais([FromQuery] string country)
        {
            return await _repository.ObtenerEmpleadoPorPais(country);
        }
        [HttpGet]
        [Route("api/TodosLosEmpleadoPorPais")]
        public async Task<List<Employees>> ObtenerTodosLosEmpleadosPorPais([FromQuery] string country)
        {
            return await _repository.ObtenerTodosLosEmpleadosPorPais(country);
        }
        [HttpGet]
        [Route("api/ElEmpleadoMasGrande")]
        public async Task<Employees> ObtenerElEmpleadoMasGrande()
        {
            return await _repository.ObtenerElEmpleadoMasGrande();
        }
    }
}
