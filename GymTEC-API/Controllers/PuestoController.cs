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
    public class PuestoController : ControllerBase
    {
        [HttpPost]
        [Route("agregarPuesto")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta insertar_Puesto(Puesto puesto)
        {
            Administrador.insertar_Puesto(puesto);
            return new respuesta("agregado"); 
        }
        
        [HttpPost]
        [Route("editarPuesto")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta editar_Puesto(Puesto puesto)
        {
            Administrador.editar_Puesto(puesto);
            return new respuesta("exito");
        }
        
        [HttpPost]
        [Route("eliminarPuesto")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta eliminar_Puesto(Puesto puesto)
        {
            Administrador.eliminar_Puesto(puesto);
            return new respuesta("exito");
        }
        
        [HttpPost]
        [Route("buscarPuesto")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IList<Puesto> buscar_Puesto(string entrada)
        {
            return Administrador.Buscar_Puesto(entrada);
            
        }
        
        
    }
}