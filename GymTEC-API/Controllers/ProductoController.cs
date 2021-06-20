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
    public class ProductoController : ControllerBase
    {
        [HttpPost]
        [Route("agregarProducto")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta insertar_Producto(Producto producto)
        {
            Administrador.insertar_Producto(producto);
            return new respuesta("agregado"); 
        }
        
        [HttpPost]
        [Route("editarProducto")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta editar_Producto(Producto producto)
        {
            Administrador.editar_Producto(producto);
            return new respuesta("exito");
        }
        
        [HttpPost]
        [Route("eliminarProducto")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta eliminar_Producto(Producto producto)
        {
            Administrador.eliminar_Producto(producto);
            return new respuesta("exito");
        }
        
        [HttpPost]
        [Route("buscarProducto")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IList<Producto> buscar_Producto(BusquedaEntrada entrada)
        {
            return Administrador.Buscar_Producto(entrada.busquedaEnt);
            
        }
        
        
    }
}