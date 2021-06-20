using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GymTEC_API.DB;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace GymTEC_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpleadoController : ControllerBase
    {
        
        [HttpPost]
        [Route("agregarEmpleado")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta insertar_Empleado(Empleado empleado)
        {
            Administrador.insertar_Empleado(empleado);
            return new respuesta("agregado"); 
        }
        
        [HttpPost]
        [Route("editarEmpleado")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta editar_Empleado(Empleado empleado)
        {
            Administrador.editar_Empleado(empleado);
            return new respuesta("exito");
        }
        
        [HttpPost]
        [Route("eliminarEmpleado")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta eliminar_Empleado(Empleado empleado)
        {
            Administrador.eliminar_Empleado(empleado);
            return new respuesta("exito");
        }
        
        [HttpPost]
        [Route("buscarEmpleado")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IList<Empleado> buscar_Empleado(BusquedaEntrada entrada)
        {
            return Administrador.Buscar_Empleado(entrada.busquedaEnt);
            
        }
        
    }
}