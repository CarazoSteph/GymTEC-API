using System;
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
        public static Empleado empleadoActual;
        public static Sucursal sucursalActual;
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

        
        /* Funcionalidad Gestionar Productos*/

        public static void insertar_Producto(Producto producto)
        {
            listaProductos.Add(producto);
        }
        public static void editar_Producto(Producto producto)
        {
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].codigoBarras.Equals(producto.codigoBarras))
                {
                    listaProductos[i].nombre = producto.nombre;
                    listaProductos[i].descripcion = producto.descripcion;
                    listaProductos[i].costo = producto.costo;
                }
            }
        }
        
        public static void eliminar_Producto(Producto producto)
        {
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].codigoBarras.Equals(producto.codigoBarras))
                {
                    listaProductos.RemoveAt(i);
                }
            } 
        }
        
        public static IList<Producto> Buscar_Producto(string busqueda)
        {
            IList<Producto> list = new List<Producto>();

            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].nombre.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaProductos[i]); }
            
                if (listaProductos[i].codigoBarras.ToString().Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaProductos[i]);  }
            
                if (listaProductos[i].descripcion.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaProductos[i]);  }
                
            }

            return list;
        }
        
        /* Funcionalidad Gestionar Empleados*/
        public static void insertar_Empleado(Empleado empleado)
        {
            listaEmpleados.Add(empleado);
        }
        public static void editar_Empleado(Empleado empleado)
        {
            for (int i = 0; i < listaEmpleados.Count; i++)
            {
                if (listaEmpleados[i].numCedula.Equals(empleado.numCedula))
                {
                    listaEmpleados[i].nombre = empleado.nombre;
                    listaEmpleados[i].direccion = empleado.direccion;
                    listaEmpleados[i].puesto = empleado.puesto;
                    listaEmpleados[i].sucursal = empleado.sucursal;
                    listaEmpleados[i].tipoPlanilla = empleado.tipoPlanilla;
                    listaEmpleados[i].salario = empleado.salario;
                    listaEmpleados[i].correoElectronico = empleado.correoElectronico;
                    listaEmpleados[i].Password = empleado.Password;
                }
            }
        }
        
        public static void eliminar_Empleado(Empleado empleado)
        {
            for (int i = 0; i < listaEmpleados.Count; i++)
            {
                if (listaEmpleados[i].numCedula.Equals(empleado.numCedula))
                {
                    listaEmpleados.RemoveAt(i);
                }
            } 
        }
        
        public static IList<Empleado> Buscar_Empleado(string busqueda)
        {
            IList<Empleado> list = new List<Empleado>();

            for (int i = 0; i < listaEmpleados.Count; i++)
            {
                if (listaEmpleados[i].nombre.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaEmpleados[i]); }
            
                if (listaEmpleados[i].numCedula.ToString().Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaEmpleados[i]);  }
            
                if (listaEmpleados[i].direccion.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaEmpleados[i]);  }
                
                if (listaEmpleados[i].puesto.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaEmpleados[i]);  }
                
                if (listaEmpleados[i].tipoPlanilla.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaEmpleados[i]);  }
                
                if (listaEmpleados[i].salario.ToString().Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaEmpleados[i]);  }
                
                if (listaEmpleados[i].correoElectronico.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaEmpleados[i]);  }
                
                if (listaEmpleados[i].Password.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaEmpleados[i]);  }
            }

            return list;
        }
        
        /* Funcionalidad Gestionar Puesto*/

        public static void insertar_Puesto(Puesto puesto)
        {
            listaPuesto.Add(puesto);
        }
        public static void editar_Puesto(Puesto puesto)
        {
            for (int i = 0; i < listaPuesto.Count; i++)
            {
                if (listaPuesto[i].id_puesto.Equals(puesto.id_puesto))
                {
                    listaPuesto[i].descripcion = puesto.descripcion;
                }
            }
        }
        
        public static void eliminar_Puesto(Puesto puesto)
        {
            for (int i = 0; i < listaPuesto.Count; i++)
            {
                if (listaPuesto[i].id_puesto.Equals(puesto.id_puesto))
                {
                    listaPuesto.RemoveAt(i);
                }
            } 
        }
        
        public static IList<Puesto> Buscar_Puesto(string busqueda)
        {
            IList<Puesto> list = new List<Puesto>();

            for (int i = 0; i < listaPuesto.Count; i++)
            {
                if (listaPuesto[i].id_puesto.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaPuesto[i]); }
            
                if (listaPuesto[i].descripcion.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaPuesto[i]);  }
                
            }

            return list;
        }
        
        /* Funcionalidad Gestionar Servicios*/

        public static void insertar_Servicio(Servicio servicio)
        {
            listaServicio.Add(servicio);
        }
        
        public static void editar_Servicio(Servicio servicio)
        {
            for (int i = 0; i < listaServicio.Count; i++)
            {
                if (listaServicio[i].nombre_servicio.Equals(servicio.nombre_servicio))
                {
                    listaServicio[i].descripcion = servicio.descripcion;
                }
            }
        }
        
        public static void eliminar_Servicio(Servicio servicio)
        {
            for (int i = 0; i < listaServicio.Count; i++)
            {
                if (listaServicio[i].nombre_servicio.Equals(servicio.nombre_servicio))
                {
                    listaServicio.RemoveAt(i);
                }
            } 
        }
        
        public static IList<Servicio> Buscar_Servicio(string busqueda)
        {
            IList<Servicio> list = new List<Servicio>();

            for (int i = 0; i < listaServicio.Count; i++)
            {
                if (listaServicio[i].nombre_servicio.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaServicio[i]); }
            
                if (listaServicio[i].descripcion.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaServicio[i]);  }
                
            }

            return list;
        }
        
        /* Funcionalidad Gestionar Inventario*/

        public static void insertar_Inventario(Inventario inventario)
        {
            listaInventario.Add(inventario);
        }
        public static void editar_Inventario(Inventario inventario)
        {
            for (int i = 0; i < listaPuesto.Count; i++)
            {
                if (listaInventario[i].numSerie.Equals(inventario.numSerie))
                {
                    listaInventario[i].tipoMaquina = inventario.tipoMaquina;
                    listaInventario[i].marca = inventario.marca;
                    listaInventario[i].costo = inventario.costo;
                    listaInventario[i].sucursal = inventario.sucursal;
                }
            }
        }
        
        public static void eliminar_Inventario(Inventario inventario)
        {
            for (int i = 0; i < listaInventario.Count; i++)
            {
                if (listaInventario[i].numSerie.Equals(inventario.numSerie))
                {
                    listaInventario.RemoveAt(i);
                }
            } 
        }
        
        public static IList<Inventario> Buscar_Inventario(string busqueda)
        {
            IList<Inventario> list = new List<Inventario>();

            for (int i = 0; i < listaInventario.Count; i++)
            {
                if (listaInventario[i].numSerie.ToString().Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaInventario[i]); }
                
                if (listaInventario[i].tipoMaquina.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaInventario[i]); }
                
                if (listaInventario[i].marca.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaInventario[i]); }
                
                if (listaInventario[i].costo.ToString().Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaInventario[i]); }
                
                if (listaInventario[i].sucursal.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaInventario[i]); }
            }

            return list;
        }
        
        /* Funcionalidad Gestionar Tipo de Equipo*/

        public static void insertar_TipoDeEquipo(TipoDeEquipo tipoDeEquipo)
        {
            listaTipoEquipo.Add(tipoDeEquipo);
        }
        
        public static void editar_TipoDeEquipo(TipoDeEquipo tipoDeEquipo)
        {
            for (int i = 0; i < listaTipoEquipo.Count; i++)
            {
                if (listaTipoEquipo[i].id_tipoEquipo.Equals(tipoDeEquipo.id_tipoEquipo))
                {
                    listaTipoEquipo[i].descripcion = tipoDeEquipo.descripcion;
                }
            }
        }
        
        public static void eliminar_TipoDeEquipo(TipoDeEquipo tipoDeEquipo)
        {
            for (int i = 0; i < listaTipoEquipo.Count; i++)
            {
                if (listaTipoEquipo[i].id_tipoEquipo.Equals(tipoDeEquipo.id_tipoEquipo))
                {
                    listaTipoEquipo.RemoveAt(i);
                }
            } 
        }
        
        public static IList<TipoDeEquipo> Buscar_TipoDeEquipo(string busqueda)
        {
            IList<TipoDeEquipo> list = new List<TipoDeEquipo>();

            for (int i = 0; i < listaTipoEquipo.Count; i++)
            {
                if (listaTipoEquipo[i].id_tipoEquipo.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaTipoEquipo[i]); }
            
                if (listaTipoEquipo[i].descripcion.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaTipoEquipo[i]);  }
                
            }

            return list;
        }
        
        /* Funcionalidad Gestionar Tipo de Planilla*/

        public static void insertar_TipoPlanilla(TipoPlanilla tipoPlanilla)
        {
            listaTipoPlanilla.Add(tipoPlanilla);
        }
        
        public static void editar_TipoPlanilla(TipoPlanilla tipoplanilla)
        {
            for (int i = 0; i < listaTipoPlanilla.Count; i++)
            {
                if (listaTipoPlanilla[i].id_TipoPlanilla.Equals(tipoplanilla.id_TipoPlanilla))
                {
                    listaTipoPlanilla[i].descripcion = tipoplanilla.descripcion;
                    listaTipoPlanilla[i].pagoMensual = tipoplanilla.pagoMensual;
                    listaTipoPlanilla[i].pagoXhora = tipoplanilla.pagoXhora;
                    listaTipoPlanilla[i].pagoXclase = tipoplanilla.pagoXclase;
                }
            }
        }
        
        public static void eliminar_TipoPlanilla(TipoPlanilla tipoPlanilla)
        {
            for (int i = 0; i < listaTipoPlanilla.Count; i++)
            {
                if (listaTipoPlanilla[i].id_TipoPlanilla.Equals(tipoPlanilla.id_TipoPlanilla))
                {
                    listaTipoPlanilla.RemoveAt(i);
                }
            } 
        }
        
        public static IList<TipoPlanilla> Buscar_TipoPlanilla(string busqueda)
        {
            IList<TipoPlanilla> list = new List<TipoPlanilla>();

            for (int i = 0; i < listaTipoPlanilla.Count; i++)
            {
                if (listaTipoPlanilla[i].id_TipoPlanilla.ToString().Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaTipoPlanilla[i]); }
            
                if (listaTipoPlanilla[i].descripcion.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaTipoPlanilla[i]);  }
                
                if (listaTipoPlanilla[i].pagoMensual.ToString().Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaTipoPlanilla[i]);  }
                
                if (listaTipoPlanilla[i].pagoXhora.ToString().Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaTipoPlanilla[i]);  }
                
                if (listaTipoPlanilla[i].pagoXclase.ToString().Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaTipoPlanilla[i]);  }
            }

            return list;
        }
        
        /* Funcionalidad Gestionar Tratamiento Spa */

        public static void insertar_Spa(Spa spa)
        {
            listaSpa.Add(spa);
        }
        
        public static void editar_Spa(Spa spa)
        {
            for (int i = 0; i < listaSpa.Count; i++)
            {
                if (listaSpa[i].id_spa.Equals(spa.id_spa))
                {
                    listaSpa[i].nombre = spa.nombre;
                }
            }
        }
        
        public static void eliminar_Spa(Spa spa)
        {
            for (int i = 0; i < listaSpa.Count; i++)
            {
                if (listaSpa[i].id_spa.Equals(spa.id_spa))
                {
                    listaSpa.RemoveAt(i);
                }
            } 
        }
        
        public static IList<Spa> Buscar_Spa(string busqueda)
        {
            IList<Spa> list = new List<Spa>();

            for (int i = 0; i < listaSpa.Count; i++)
            {
                if (listaSpa[i].id_spa.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaSpa[i]); }
            
                if (listaSpa[i].nombre.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaSpa[i]);  }
                
            }

            return list;
        }
    }
}