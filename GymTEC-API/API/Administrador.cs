using System.Collections;
using System.Collections.Generic;

namespace GymTEC_API.DB
{
    public class Administrador
    {
        //attributes
        public string correoElectronico;
        private string contrasena;
        public static Usuario usuarioActual;
        public static IList<Clases> listaClases;
        public static IList<Empleado> listaEmpleados;
        public static IList<Inventario> listaInventario;
        public static IList<Producto> listaProductos;
        public static IList<Puesto> listaPuesto;
        public static IList<Servicio> listaServicio;
        public static IList<Spa> listaSpa;
        public static IList<Sucursal> listaSucursal;
        public static IList<TipoDeEquipo> listaTipoEquipo;
        public static IList<TipoPlanilla> listaTipoPlanilla;
        public static IList<Usuario> listaUsuario;
        
        //contruuctor
        public Administrador(string correoElectronico, string contrasena)
        {
            this.correoElectronico = correoElectronico;
            this.contrasena = contrasena;
        }
        
        //getters and setters
        public string CorreoElectronico
        {
            get => correoElectronico;
            set => correoElectronico = value;
        }

        public string Contrasena
        {
            get => contrasena;
            set => contrasena = value;
        }

        // Funcion que verifica el log in proveniente de la pagina web
        // Entrada: un string con el correo y otro con la contrasena
        // Salida: un string del tipo de usuario que ingresa
        // Restricciones: las entradas deben ser strings
        public static string login(string loginCorreo, string loginContrasena)
        {
            if (loginCorreo.Equals("admin") && loginContrasena.Equals("123"))
            {
                return "admin";
            }
            for (int i = 0; i < lista_Usuarios.Count; i++)
            {
                if (lista_Usuarios[i].correo.Equals(loginCorreo) &&
                    lista_Usuarios[i].Contrasena.Equals(loginContrasena))
                {
                    return "usuario";
                }
            }
            
            return "denegar";
        }

        public static void registrarUsuario(Usuario nuevoUsuario)
        {
            lista_Usuarios.Add(nuevoUsuario);
            nuevoUsuario.InsertarUsuarioBaseDatos(nuevoUsuario);
        }
    }
}