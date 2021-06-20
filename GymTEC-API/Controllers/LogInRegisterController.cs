using System;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GymTEC_API.DB;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace GymTEC_API.Controllers
{
    //funcion encargada del registro y de logeo de los usuarios
    [ApiController]
    [Route("[controller]")]
    public class LogInRegisterController : ControllerBase
    {
        // funcion encargada de verificar los datos de log in de un usuario
        //Entrada: los datos en forma de loginEntrada de correo y contraseña
        //Salida: la respuesta de si es admitido o no, y si es usuario o administrador
        //Restricciones: no posee restricciones
        [HttpPost]
        [Route("verificar")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta Verificar_Login(LoginEntrada login)
        {
            //Proceso de Log In
            if (Administrador.login(login.correo, login.contrasena) == "admin")
            {
                return new respuesta("admin");
            }
            if (Administrador.login(login.correo, login.contrasena) == "usuario")
            {
                return new respuesta("usuario");
            }
            return new respuesta("denegar");
        }
        
        [HttpPost]
        [Route("registrar")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public respuesta Verificar_registro(Usuario nuevoUsuario)
        {
            string jsonString = JsonSerializer.Serialize(nuevoUsuario);
            Console.WriteLine("Lo que llega de registrarse: "+ jsonString);

            Administrador.registrarUsuario(nuevoUsuario);
            return new respuesta("ok");
        }
        
        
        
    }
}