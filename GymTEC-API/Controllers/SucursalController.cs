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
    public class SucursalController : ControllerBase
    {
        [HttpPost]
        [Route("agregarSucursal")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta insertar_Sucursal(Sucursal sucursal)
        {
            Administrador.insertar_Sucursal(sucursal);
            return new respuesta("agregado"); 
        }
        
        [HttpPost]
        [Route("editarSucursal")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta editar_Sucursal(Sucursal sucursal)
        {
            Administrador.editar_Sucursal(sucursal);
            return new respuesta("exito");
        }
        
        [HttpPost]
        [Route("eliminarSucursal")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta eliminar_Sucursal(Sucursal sucursal)
        {
            Administrador.eliminar_Sucursal(sucursal);
            return new respuesta("exito");
        }
        
        [HttpPost]
        [Route("buscarSucursal")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IList<Sucursal> buscar_Sucursal(string entrada)
        {
            return Administrador.Buscar_Sucursal(entrada);
            
        }
        
        [HttpPost]
        [Route("ONOFFSPA")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta ONOFFSPA(Sucursal sucursal)
        {
            Administrador.ONOFFSPA(sucursal);
            return new respuesta("exito");;
            
        }
        
        [HttpPost]
        [Route("ONOFFTIENDA")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta ONOFFTIENDA(Sucursal sucursal)
        {
            Administrador.ONOFFTIENDA(sucursal);
            return new respuesta("exito");;
            
        }
        
        
        
        
    }
}