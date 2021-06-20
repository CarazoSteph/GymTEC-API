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
    public class GenerarPlanillaController : ControllerBase
    {
        
        [HttpPost]
        [Route("generarPlanillaMensual")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public List<PlanillaMensual> planillaMensual(Sucursal sucursal)
        {
            return Administrador.generarPlanillaMensual(sucursal); 
        }
        
        [HttpPost]
        [Route("generarPlanillaHoras")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public List<planillaHoras> planillaHoras(Sucursal sucursal)
        {
            return Administrador.generarPlanillaHoras(sucursal); 
        }
        
        [HttpPost]
        [Route("generarPlanillaClases")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public List<planillaClases> planillaClases(Sucursal sucursal)
        {
            return Administrador.generarPlanillaClases(sucursal); 
        }
        
        
    }
}