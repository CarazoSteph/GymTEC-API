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
    public class TipoPlanillaController : ControllerBase
    {
        [HttpPost]
        [Route("agregarTipoPlanilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta insertar_TipoPlanilla(TipoPlanilla tipoPlanilla)
        {
            Administrador.insertar_TipoPlanilla(tipoPlanilla);
            return new respuesta("agregado"); 
        }
        
        [HttpPost]
        [Route("editarTipoPlanilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta editar_TipoPlanilla(TipoPlanilla tipoplanilla)
        {
            Administrador.editar_TipoPlanilla(tipoplanilla);
            return new respuesta("exito");
        }
        
        [HttpPost]
        [Route("eliminarTipoPlanilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta eliminar_TipoPlanilla(TipoPlanilla tipoPlanilla)
        {
            Administrador.eliminar_TipoPlanilla(tipoPlanilla);
            return new respuesta("exito");
        }
        
        [HttpPost]
        [Route("buscarTipoPlanilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IList<TipoPlanilla> buscar_TipoPlanilla(string entrada)
        {
            return Administrador.Buscar_TipoPlanilla(entrada);
        }
        
        
    }
}