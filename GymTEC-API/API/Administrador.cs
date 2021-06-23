using System;
using System.Collections;
using System.Collections.Generic;
using GymTEC_API.BasesDatos;
using GymTEC_API.Controllers;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;

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
        
        //Mongo Conection
        public static MongoDBConnection connMongo = new MongoDBConnection();
        public static SQLServerConnection connSQLServer = new SQLServerConnection();
        
        //contruuctor
        public Administrador(string correoElectronico, string contrasena)
        {
            this.correoElectronico = correoElectronico;
            this.contrasena = contrasena;
            listaClases = new List<Clases>();
            listaEmpleados = new List<Empleado>();
            listaInventario = new List<Inventario>();
            listaProductos = new List<Producto>();
            listaPuesto = new List<Puesto>();
            listaServicio = new List<Servicio>();
            listaSpa = new List<Spa>();
            listaSucursal = new List<Sucursal>();
            listaTipoEquipo = new List<TipoDeEquipo>();
            listaTipoPlanilla = new List<TipoPlanilla>();
            listaUsuario = new List<Usuario>();
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
            for (int i = 0; i < listaUsuario.Count; i++)
            {
                if (listaEmpleados[i].correoElectronico.Equals(loginCorreo) &&
                    listaEmpleados[i].Password.Equals(loginContrasena))
                {
                    
                        empleadoActual = listaEmpleados[i];
                        try
                        {
                        for (int j = 0; j < listaSucursal.Count; j++)
                        {
                            if (listaSucursal[j].empleadoAdmin.Equals(listaEmpleados[i].nombre))
                            {
                                sucursalActual = listaSucursal[j];
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }

                    return "admin";
                }
            }

            for (int i = 0; i < listaUsuario.Count; i++)
            {
                if (listaUsuario[i].correoElectronico.Equals(loginCorreo) &&
                    listaUsuario[i].Password.Equals(loginContrasena))
                {
                    usuarioActual = listaUsuario[i];
                    return "usuario";
                }
            }
            
            return "denegar";
        }

        public static void registrarUsuario(Usuario nuevoUsuario)
        {
            connMongo.insertarUsuario(nuevoUsuario);
            connSQLServer.insertUsuario(nuevoUsuario);
            listaUsuario.Add(nuevoUsuario);
            
        }

        
        /* Funcionalidad Gestionar Productos*/

        public static void insertar_Producto(Producto producto)
        {
            connSQLServer.insertProducto(producto);
            listaProductos.Add(producto);
        }
        public static void editar_Producto(Producto producto)
        {
            connSQLServer.updateProducto(producto);
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
            connSQLServer.eliminarProducto(producto);
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
                
                if (listaProductos[i].costo.ToString().Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaProductos[i]);  }
                
            }

            return list;
        }
        
        /* Funcionalidad Gestionar Empleados*/
        public static void insertar_Empleado(Empleado empleado)
        {
            connMongo.insertarEmpleado(empleado);
            connSQLServer.insertEmpleado(empleado);
            listaEmpleados.Add(empleado);
        }
        public static void editar_Empleado(Empleado empleado)
        {
            for (int i = 0; i < listaEmpleados.Count; i++)
            {
                connSQLServer.updateEmpleado(empleado);
                connMongo.EditarEmpleado(empleado);
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
            connSQLServer.eliminarEmpleado(empleado);
            connMongo.EliminarEmpleado(empleado);
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
                
                if (listaEmpleados[i].tipoPlanilla.ToString().Equals(busqueda, StringComparison.OrdinalIgnoreCase))
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
            connSQLServer.insertPuesto(puesto);
            listaPuesto.Add(puesto);
        }
        public static void editar_Puesto(Puesto puesto)
        {
            connSQLServer.UpdatePuesto(puesto);
            for (int i = 0; i < listaPuesto.Count; i++)
            {
                if (listaPuesto[i].idPuesto.Equals(puesto.idPuesto))
                {
                    listaPuesto[i].nombre = puesto.nombre;
                    listaPuesto[i].descripcion = puesto.descripcion;
                }
            }
        }
        
        public static void eliminar_Puesto(Puesto puesto)
        {
            connSQLServer.eliminarPuesto(puesto);
            for (int i = 0; i < listaPuesto.Count; i++)
            {
                if (listaPuesto[i].idPuesto.Equals(puesto.idPuesto))
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
                if (listaPuesto[i].idPuesto.ToString().Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaPuesto[i]); }
                
                if (listaPuesto[i].nombre.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaPuesto[i]); }
            
                if (listaPuesto[i].descripcion.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaPuesto[i]);  }
                
            }

            return list;
        }
        
        /* Funcionalidad Gestionar Servicios*/

        public static void insertar_Servicio(Servicio servicio)
        {
            connSQLServer.insertServicio(servicio);
            listaServicio.Add(servicio);
        }
        
        public static void editar_Servicio(Servicio servicio)
        {
            connSQLServer.updateServicio(servicio);
            for (int i = 0; i < listaServicio.Count; i++)
            {
                if (listaServicio[i].nombreServicio.Equals(servicio.nombreServicio))
                {
                    listaServicio[i].IdServicio = servicio.IdServicio;
                    listaServicio[i].descripcion = servicio.descripcion;
                }
            }
        }
        
        public static void eliminar_Servicio(Servicio servicio)
        {
            connSQLServer.eliminarServicio(servicio);
            for (int i = 0; i < listaServicio.Count; i++)
            {
                if (listaServicio[i].nombreServicio.Equals(servicio.nombreServicio))
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
                if (listaServicio[i].nombreServicio.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaServicio[i]); }
            
                if (listaServicio[i].IdServicio.ToString().Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaServicio[i]);  }
                
                if (listaServicio[i].descripcion.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaServicio[i]);  }
                
            }

            return list;
        }
        
        /* Funcionalidad Gestionar Inventario*/

        public static void insertar_Inventario(Inventario inventario)
        {
            connSQLServer.insertInventario(inventario);
            listaInventario.Add(inventario);
        }
        public static void editar_Inventario(Inventario inventario)
        {
            connSQLServer.updateinventario(inventario);
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
            connSQLServer.eliminarInventario(inventario);
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
            connSQLServer.insertTipoDeEquipo(tipoDeEquipo);
            listaTipoEquipo.Add(tipoDeEquipo);
        }
        
        public static void editar_TipoDeEquipo(TipoDeEquipo tipoDeEquipo)
        {
            connSQLServer.updateTipoDeEquipo(tipoDeEquipo);
            for (int i = 0; i < listaTipoEquipo.Count; i++)
            {
                if (listaTipoEquipo[i].idTipoEquipo.Equals(tipoDeEquipo.idTipoEquipo))
                {
                    listaTipoEquipo[i].nombreTipoEquipo = tipoDeEquipo.nombreTipoEquipo;
                    listaTipoEquipo[i].descripcion = tipoDeEquipo.descripcion;
                }
            }
        }
        
        public static void eliminar_TipoDeEquipo(TipoDeEquipo tipoDeEquipo)
        {
            connSQLServer.eliminarTipoDeEquipo(tipoDeEquipo);
            for (int i = 0; i < listaTipoEquipo.Count; i++)
            {
                if (listaTipoEquipo[i].idTipoEquipo.Equals(tipoDeEquipo.idTipoEquipo))
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
                if (listaTipoEquipo[i].idTipoEquipo.ToString().Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaTipoEquipo[i]); }
                
                if (listaTipoEquipo[i].nombreTipoEquipo.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaTipoEquipo[i]);  }
            
                if (listaTipoEquipo[i].descripcion.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaTipoEquipo[i]);  }
                
            }

            return list;
        }
        
        /* Funcionalidad Gestionar Tipo de Planilla*/

        public static void insertar_TipoPlanilla(TipoPlanilla tipoPlanilla)
        {
            connSQLServer.insertTipoPlanilla(tipoPlanilla);
            listaTipoPlanilla.Add(tipoPlanilla);
        }
        
        public static void editar_TipoPlanilla(TipoPlanilla tipoplanilla)
        {
            connSQLServer.updateTipoPlanilla(tipoplanilla);
            for (int i = 0; i < listaTipoPlanilla.Count; i++)
            {
                if (listaTipoPlanilla[i].idTipoPlanilla.Equals(tipoplanilla.idTipoPlanilla))
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
            connSQLServer.EliminarTipoPlanilla(tipoPlanilla);
            for (int i = 0; i < listaTipoPlanilla.Count; i++)
            {
                if (listaTipoPlanilla[i].idTipoPlanilla.Equals(tipoPlanilla.idTipoPlanilla))
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
                if (listaTipoPlanilla[i].idTipoPlanilla.ToString().Equals(busqueda, StringComparison.OrdinalIgnoreCase))
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
            connSQLServer.insertSpa(spa);
            listaSpa.Add(spa);
        }
        
        public static void editar_Spa(Spa spa)
        {
            connSQLServer.updateSpa(spa);
            for (int i = 0; i < listaSpa.Count; i++)
            {
                if (listaSpa[i].idSpa.Equals(spa.idSpa))
                {
                    listaSpa[i].nombre = spa.nombre;
                }
            }
        }
        
        public static void eliminar_Spa(Spa spa)
        {
            connSQLServer.eliminarSpa(spa);
            for (int i = 0; i < listaSpa.Count; i++)
            {
                if (listaSpa[i].idSpa.Equals(spa.idSpa))
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
                if (listaSpa[i].idSpa.ToString().Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaSpa[i]); }
            
                if (listaSpa[i].nombre.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaSpa[i]);  }
                
            }

            return list;
        }
        
        /* Funcionalidad Gestionar Sucursal */

        public static void insertar_Sucursal(Sucursal sucursal)
        {
            connSQLServer.insertSucursal(sucursal);
            listaSucursal.Add(sucursal);
        }
        
        public static void editar_Sucursal(Sucursal sucursal)
        {
            connSQLServer.updateSucursal(sucursal);
            for (int i = 0; i < listaSucursal.Count; i++)
            {
                if (listaSucursal[i].nombre.Equals(sucursal.nombre))
                {
                    listaSucursal[i].direccion = sucursal.direccion;
                    listaSucursal[i].fechaApertura = sucursal.fechaApertura;
                    listaSucursal[i].horarioAtencion = sucursal.horarioAtencion;
                    listaSucursal[i].empleadoAdmin = sucursal.empleadoAdmin;
                    listaSucursal[i].capacidadMax = sucursal.capacidadMax;
                    listaSucursal[i].numTelefono = sucursal.numTelefono;
                    
                }
            }
        }
        
        public static void eliminar_Sucursal(Sucursal sucursal)
        {
            connSQLServer.eliminarSucursal(sucursal);
            for (int i = 0; i < listaSpa.Count; i++)
            {
                if (listaSucursal[i].nombre.Equals(sucursal.nombre))
                {
                    listaSucursal.RemoveAt(i);
                }
            } 
        }
        
        public static IList<Sucursal> Buscar_Sucursal(string busqueda)
        {
            IList<Sucursal> list = new List<Sucursal>();

            for (int i = 0; i < listaSucursal.Count; i++)
            {
                if (listaSucursal[i].nombre.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaSucursal[i]); }
            
                if (listaSucursal[i].direccion.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaSucursal[i]);  }
                
                if (listaSucursal[i].fechaApertura.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaSucursal[i]);  }
                
                if (listaSucursal[i].horarioAtencion.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaSucursal[i]);  }
                
                if (listaSucursal[i].empleadoAdmin.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaSucursal[i]);  }
                
                if (listaSucursal[i].capacidadMax.ToString().Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaSucursal[i]);  }
                
                if (listaSucursal[i].numTelefono.ToString().Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaSucursal[i]);  }
                
            }

            return list;
        }

        public static void ONOFFSPA(Sucursal sucursal)
        {
            for (int i = 0; i < listaSucursal.Count; i++)
            {
                if (listaSucursal[i].nombre.Equals(sucursal.nombre))
                {
                    if (listaSucursal[i].spa == "on")
                    {
                        listaSucursal[i].spa = "off";
                    } else if (listaSucursal[i].spa == "off")
                    {
                        listaSucursal[i].spa = "on";}
                }
            }
        }
        public static void ONOFFTIENDA(Sucursal sucursal)
        {
            for (int i = 0; i < listaSucursal.Count; i++)
            {
                if (listaSucursal[i].nombre.Equals(sucursal.nombre))
                {
                    if (listaSucursal[i].tienda == "on")
                    {
                        listaSucursal[i].tienda = "off";
                    } else if (listaSucursal[i].tienda == "off")
                    {
                        listaSucursal[i].tienda = "on";}
                }
            }
        }
        
        /* Funcionalidad Generacion de planilla */

        public static IList<PlanillaMensual> generarPlanillaMensual(Sucursal sucursal)
        {
            IList<PlanillaMensual> list = new List<PlanillaMensual>();

            for (int i = 0; i < listaEmpleados.Count; i++)
            {
                if (listaEmpleados[i].sucursal.Equals(sucursal.nombre))
                {
                    for (int j = 0; j < listaTipoPlanilla.Count; j++)
                    {
                        if (listaEmpleados[i].tipoPlanilla.Equals(listaTipoPlanilla[j].idTipoPlanilla))
                        {
                            list.Add(new PlanillaMensual(listaEmpleados[i].nombre,listaEmpleados[i].numCedula,
                                                            listaTipoPlanilla[j].pagoMensual));
                        }
                    }
                }
            }

            return list;
        }
        public static IList<planillaHoras> generarPlanillaHoras(Sucursal sucursal)
        {
            IList<planillaHoras> list = new List<planillaHoras>();

            for (int i = 0; i < listaEmpleados.Count; i++)
            {
                if (listaEmpleados[i].sucursal.Equals(sucursal.nombre))
                {
                    for (int j = 0; j < listaTipoPlanilla.Count; j++)
                    {
                        if (listaEmpleados[i].tipoPlanilla.Equals(listaTipoPlanilla[j].idTipoPlanilla))
                        {
                            list.Add(new planillaHoras(listaEmpleados[i].nombre,listaEmpleados[i].numCedula,
                                listaEmpleados[i].horasTrabajadas,(listaTipoPlanilla[j].pagoXhora*listaEmpleados[i].horasTrabajadas)));
                        }
                    }
                }
            }

            return list;
        }
        public static IList<planillaClases> generarPlanillaClases(Sucursal sucursal)
        {
            IList<planillaClases> list = new List<planillaClases>();

            for (int i = 0; i < listaEmpleados.Count; i++)
            {
                if (listaEmpleados[i].sucursal.Equals(sucursal.nombre))
                {
                    for (int j = 0; j < listaTipoPlanilla.Count; j++)
                    {
                        if (listaEmpleados[i].tipoPlanilla.Equals(listaTipoPlanilla[j].idTipoPlanilla))
                        {
                            list.Add(new planillaClases(listaEmpleados[i].nombre,listaEmpleados[i].numCedula,
                                listaEmpleados[i].clasesRealizadas,(listaTipoPlanilla[j].pagoXclase*listaEmpleados[i].clasesRealizadas)));
                        }
                    }
                }
            }

            return list;
        }
        
        /* Funcionalidad Gestionar Clases */

        public static void insertar_Clases(Clases clase)
        {
            connSQLServer.insertClases(clase);
            listaClases.Add(clase);
            try
            {
                for (int i = 0; i < listaEmpleados.Count; i++)
                {
                    if (listaEmpleados[i].nombre.Equals(clase.instructor))
                    {
                        listaEmpleados[i].horasTrabajadas = listaEmpleados[i].horasTrabajadas + 4;
                        listaEmpleados[i].clasesRealizadas++;
                    }
                }
            }
            catch (Exception e)
            {
                return;
            }
        }
        public static void eliminar_Clases(Clases clases)
        {
            connSQLServer.eliminarClases(clases);
            for (int i = 0; i < listaClases.Count; i++)
            {
                if (listaClases[i].idClase.Equals(clases.idClase))
                {
                    listaClases.RemoveAt(i);
                }
            } 
        }
        
        public static IList<Clases> Buscar_Clases(string busqueda)
        {
            IList<Clases> list = new List<Clases>();

            for (int i = 0; i < listaClases.Count; i++)
            {
                if (listaClases[i].idClase.ToString().Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaClases[i]); }
            
                if (listaClases[i].tipo.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaClases[i]);  }
                
                if (listaClases[i].instructor.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaClases[i]);  }
                
                if (listaClases[i].individual.ToString().Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaClases[i]);  }
                
                if (listaClases[i].capacidad.ToString().Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaClases[i]);  }
                
                if (listaClases[i].fecha.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaClases[i]);  }
                
                if (listaClases[i].horaInicio.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaClases[i]);  }
                
                if (listaClases[i].horaFin.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
                { list.Add(listaClases[i]);  }
                
            }

            return list;
        }

        public static void AsociarSpa(Spa spa)
        {
            sucursalActual.listaSpas.Add(spa);
        }
        
        public static void AsociarProducto(Producto producto)
        {
           sucursalActual.listaproductos.Add(producto);
                
        }
        
        public static void AsociarInventario(Inventario inventario)
        {
           
           sucursalActual.ListaInventario.Add(inventario);
                
        }
        
        public static void AsociarServicio(Servicio servicio)
        {
           sucursalActual.ListaServicios.Add(servicio);
                
        }
        
        public static void DesasociarSpa(Spa spa)
        {
            for (int i = 0; i < listaSucursal.Count; i++)
            {
                if (listaSucursal[i].nombre.Equals(sucursalActual.nombre))
                {
                    for (int j = 0; i < listaSucursal[i].listaSpas.Count; j++)
                    {
                        if (listaSucursal[i].listaSpas[j].nombre.Equals(spa.nombre))
                        {
                            listaSucursal[i].listaSpas.RemoveAt(j);
                        }
                    } 
                }
            }
        }
        public static void DesasociarProducto(Producto producto)
        {
            for (int i = 0; i < listaSucursal.Count; i++)
            {
                if (listaSucursal[i].nombre.Equals(sucursalActual.nombre))
                {
                    for (int j = 0; i < listaSucursal[i].listaproductos.Count; j++)
                    {
                        if (listaSucursal[i].listaproductos[j].codigoBarras.Equals(producto.codigoBarras))
                        {
                            listaSucursal[i].listaproductos.RemoveAt(j);
                        }
                    } 
                }
            }
        }
        
        public static void DesasociarInventario(Inventario inventario)
        {
            for (int i = 0; i < listaSucursal.Count; i++)
            {
                if (listaSucursal[i].nombre.Equals(sucursalActual.nombre))
                {
                    for (int j = 0; i < listaSucursal[i].ListaInventario.Count; j++)
                    {
                        if (listaSucursal[i].ListaInventario[j].numSerie.Equals(inventario.numSerie))
                        {
                            listaSucursal[i].ListaInventario.RemoveAt(j);
                        }
                    } 
                }
            }
        }
        
        public static void DesasociarServicio(Servicio servicio)
        {
            for (int i = 0; i < listaSucursal.Count; i++)
            {
                if (listaSucursal[i].nombre.Equals(sucursalActual.nombre))
                {
                    for (int j = 0; i < listaSucursal[i].ListaServicios.Count; j++)
                    {
                        if (listaSucursal[i].ListaServicios[j].nombreServicio.Equals(servicio.nombreServicio))
                        {
                            listaSucursal[i].ListaServicios.RemoveAt(j);
                        }
                    } 
                }
            }
        }
        
        /* Funcionalidad Vista Cliente*/

        public static string registrarUsuarioClase(Clases clases)
        {
            if (clases.capacidad == clases.ListaUsuarios.Count)
            {
                return "lleno";
            }
            for (int i = 0; i < listaClases.Count; i++)
            {
                if (listaClases[i].idClase.Equals(clases.idClase))
                {
                    if (listaClases[i].capacidad >= listaClases[i].ListaUsuarios.Count)
                        listaClases[i].ListaUsuarios.Add(usuarioActual);
                    return "agregado";
                }
            }
            return "lleno";
        }
        
    }
}