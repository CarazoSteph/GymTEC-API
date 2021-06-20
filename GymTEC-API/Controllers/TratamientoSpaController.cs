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
    public class TratamientoSpaController : ControllerBase
    {
        [HttpPost]
        [Route("agregarSpa")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta insertar_Spa(Spa spa)
        {
            Administrador.insertar_Spa(spa);
            return new respuesta("agregado"); 
        }
        
        [HttpPost]
        [Route("editarSpa")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta editar_Spa(Spa edicion)
        {
            Administrador.editar_Spa(edicion);
            return new respuesta("exito");
        }
        
        [HttpPost]
        [Route("eliminarSpa")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta eliminar_Spa(Spa spa)
        {
            Administrador.eliminar_Spa(spa.nombre);
            return new respuesta("exito");
        }
        
        [HttpPost]
        [Route("buscarSpa")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IList<Spa> buscar_Tipo(BusquedaEntrada entrada)
        {
            return Administrador.Buscar_Spa(entrada.busquedaEnt);
        }
        

    }
}