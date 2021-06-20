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
    public class ConfiguracionGymController : ControllerBase
    {
        
        [HttpPost]
        [Route("agregarClases")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta insertar_Clases(Clases clase)
        {
            Administrador.insertar_Clases(clase);
            return new respuesta("agregado"); 
        }
        
        [HttpPost]
        [Route("eliminarClases")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta eliminar_Clases(Clases empleado)
        {
            Administrador.eliminar_Clases(empleado);
            return new respuesta("exito");
        }
        
        [HttpPost]
        [Route("buscarClases")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IList<Clases> buscar_Clases(BusquedaEntrada entrada)
        {
            return Administrador.Buscar_Clases(entrada.busquedaEnt);
            
        }
        
        [HttpPost]
        [Route("AsociarSpa")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta AsociarSpa(Spa spa)
        {
            Administrador.AsociarSpa(spa);
            return new respuesta("exito");
        }
        [HttpPost]
        [Route("DesasociarSpa")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta DesasociarSpa(Spa spa)
        {
            Administrador.DesasociarSpa(spa);
            return new respuesta("exito");
        }
        
        [HttpPost]
        [Route("AsociarProducto")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta AsociarProducto(Producto producto)
        {
            Administrador.AsociarProducto(producto);
            return new respuesta("exito");
        }
        [HttpPost]
        [Route("DesasociarProducto")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta DesasociarProducto(Producto producto)
        {
            Administrador.DesasociarProducto(producto);
            return new respuesta("exito");
        }
        
        [HttpPost]
        [Route("AsociarInventario")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta AsociarInventario(Inventario inventario)
        {
            Administrador.AsociarInventario(inventario);
            return new respuesta("exito");
        }
        [HttpPost]
        [Route("DesasociarInventario")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta DesasociarInventario(Inventario inventario)
        {
            Administrador.DesasociarInventario(inventario);
            return new respuesta("exito");
        }
        
        [HttpPost]
        [Route("AsociarServicio")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta AsociarServicio(Servicio servicio)
        {
            Administrador.AsociarServicio(servicio);
            return new respuesta("exito");
        }
        [HttpPost]
        [Route("DesasociarServicio")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta DesasociarServicio(Servicio servicio)
        {
            Administrador.DesasociarServicio(servicio);
            return new respuesta("exito");
        }
        
        
    }
}