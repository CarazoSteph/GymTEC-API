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
    public class TipoEquipoController : ControllerBase
    {
        
        [HttpPost]
        [Route("agregarTipoDeEquipo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta insertar_TipoDeEquipo(TipoDeEquipo tipoDeEquipo)
        {
            Administrador.insertar_TipoDeEquipo(tipoDeEquipo);
            return new respuesta("agregado"); 
        }
        
        [HttpPost]
        [Route("editarTipoDeEquipo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta editar_TipoDeEquipo(TipoDeEquipo tipoDeEquipo)
        {
            Administrador.editar_TipoDeEquipo(tipoDeEquipo);
            return new respuesta("exito");
        }
        
        [HttpPost]
        [Route("eliminarTipoDeEquipo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta eliminar_TipoDeEquipo(TipoDeEquipo tipoDeEquipo)
        {
            Administrador.eliminar_TipoDeEquipo(tipoDeEquipo);
            return new respuesta("exito");
        }
        
        [HttpPost]
        [Route("buscarTipoDeEquipo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IList<TipoDeEquipo> buscar_TipoDeEquipo(BusquedaEntrada entrada)
        {
            return Administrador.Buscar_TipoDeEquipo(entrada.busquedaEnt);
            
        }
        
        
    }
}