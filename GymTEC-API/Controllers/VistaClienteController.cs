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
    public class VistaClienteController
    {
        
        [HttpPost]
        [Route("registrarseClases")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta RegistrarseClases(Usuario usuario)
        {
            Administrador.registrarUsuarioClase(usuario);
            return new respuesta("agregado"); 
        }
        
    }
}