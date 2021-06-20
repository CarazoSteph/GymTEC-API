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
    public class ServicioController : ControllerBase
    {
        
        [HttpPost]
        [Route("agregarServicio")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta insertar_Servicio(Servicio servicio)
        {
            Administrador.insertar_Servicio(servicio);
            return new respuesta("agregado"); 
        }
        
        [HttpPost]
        [Route("editarServicio")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta editar_Servicio(Servicio servicio)
        {
            Administrador.editar_Servicio(servicio);
            return new respuesta("exito");
        }
        
        [HttpPost]
        [Route("eliminarServicio")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta eliminar_Servicio(Servicio servicio)
        {
            Administrador.eliminar_Servicio(servicio);
            return new respuesta("exito");
        }
        
        [HttpPost]
        [Route("buscarServicio")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IList<Servicio> buscar_Servicio(string entrada)
        {
            return Administrador.Buscar_Servicio(entrada);
            
        }
        
    }
}