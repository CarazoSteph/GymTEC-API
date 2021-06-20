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
    public class InventarioController : ControllerBase
    {
        [HttpPost]
        [Route("agregarInventario")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta insertar_Inventario(Inventario inventario)
        {
            Administrador.insertar_Inventario(inventario);
            return new respuesta("agregado"); 
        }
        
        [HttpPost]
        [Route("editarInventario")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta editar_Inventario(Inventario inventario)
        {
            Administrador.editar_Inventario(inventario);
            return new respuesta("exito");
        }
        
        [HttpPost]
        [Route("eliminarInventario")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta eliminar_Inventario(Inventario inventario)
        {
            Administrador.eliminar_Inventario(inventario);
            return new respuesta("exito");
        }
        
        [HttpPost]
        [Route("buscarInventario")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IList<Inventario> buscar_Inventario(BusquedaEntrada entrada)
        {
            return Administrador.Buscar_Inventario(entrada.busquedaEnt);
            
        }
    }
}