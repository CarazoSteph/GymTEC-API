using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymTEC_API.BasesDatos;
using GymTEC_API.DB;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GymTEC_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Administrador host = new Administrador("localHost","123");
            
            Administrador.connSQLServer.iniciar_Base_Datos();

            IList<UsuarioMongo> listacontrasenas = Administrador.connMongo.obtenerDatosMongo();
            for (int i = 0; i < listacontrasenas.Count; i++)
            {
                for (int j = 0; j < Administrador.listaEmpleados.Count; j++)
                {
                    if (Administrador.listaEmpleados[j].numCedula.Equals(listacontrasenas[i].numCedula))
                    {
                        Administrador.listaEmpleados[j].Password = Administrador.connMongo.desencriptarMD5(listacontrasenas[i].contrasena);
                    }
                }
                for (int k = 0; k < Administrador.listaUsuario.Count; k++)
                {
                    if (Administrador.listaUsuario[k].numCedula.Equals(listacontrasenas[i].numCedula))
                    {
                        Administrador.listaUsuario[k].Password = Administrador.connMongo.desencriptarMD5(listacontrasenas[i].contrasena);
                    }
                }
            }

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}