using System;
using System.Collections.Generic;
using System.Data;
using GymTEC_API.DB;
using Microsoft.Data.SqlClient;

namespace GymTEC_API.BasesDatos
{
    public class SQLServerConnection
    {

        public SqlConnection conecccionBD;
        public Microsoft.Data.SqlClient.SqlParameterCollection Parameters { get; }

        public SQLServerConnection()
        {
            conecccionBD = new SqlConnection("server=ADRIAN; database=GymTEC ; integrated security = true");
            Console.WriteLine("Se conecto a la base de datos SQL SERVER con exito");
        }

        public void iniciar_Base_Datos()
        {
            conecccionBD.Open();
            string queryEmpleado = "SELECT * FROM EMPLEADO";
            SqlCommand cmd = new SqlCommand(queryEmpleado, conecccionBD);
            SqlDataReader datos = cmd.ExecuteReader();
            while (datos.Read())
            {
                Administrador.listaEmpleados.Add(new Empleado(
                    Convert.ToInt32(datos["numCedula"]),
                    datos["nombre"].ToString(),
                    datos["direccion"].ToString(),
                    datos["puesto"].ToString(),
                    datos["sucursal"].ToString(),
                    Convert.ToInt32(datos["_IDTipoPlanilla"]),
                    Convert.ToInt32(datos["salario"]),
                    datos["correoElectronico"].ToString(),
                    "123",
                    Convert.ToInt32(datos["horasTrabajadas"]),
                    Convert.ToInt32(datos["clasesRealizadas"])));
            }

            conecccionBD.Close();
            conecccionBD.Open();
            string queryInventario = "SELECT * FROM INVENTARIO";
            cmd = new SqlCommand(queryInventario, conecccionBD);
            datos = cmd.ExecuteReader();
            while (datos.Read())
            {
                Administrador.listaInventario.Add(new Inventario(
                    datos["tipoMaquina"].ToString(),
                    datos["marca"].ToString(),
                    Convert.ToInt32(datos["numSerie"]),
                    Convert.ToInt32(datos["costo"]),
                    datos["sucursal"].ToString()));
            }

            conecccionBD.Close();
            conecccionBD.Open();
            string queryProductos = "SELECT * FROM PRODUCTO";
            cmd = new SqlCommand(queryProductos, conecccionBD);
            datos = cmd.ExecuteReader();
            while (datos.Read())
            {
                Administrador.listaProductos.Add(new Producto(
                    datos["nombre"].ToString(),
                    Convert.ToInt32(datos["codigoBarras"]),
                    datos["descripcion"].ToString(),
                    Convert.ToInt32(datos["costo"])));
            }

            conecccionBD.Close();
            conecccionBD.Open();
            string queryPuestos = "SELECT * FROM PUESTO";
            cmd = new SqlCommand(queryPuestos, conecccionBD);
            datos = cmd.ExecuteReader();
            while (datos.Read())
            {
                Administrador.listaPuesto.Add(new Puesto(
                    Convert.ToInt32(datos["_IDPuesto"]),
                    datos["NombrePuesto"].ToString(),
                    datos["descripcion"].ToString()));
            }

            conecccionBD.Close();
            conecccionBD.Open();
            string queryServicio = "SELECT * FROM SERVICIO";
            cmd = new SqlCommand(queryServicio, conecccionBD);
            datos = cmd.ExecuteReader();
            while (datos.Read())
            {
                Administrador.listaServicio.Add(new Servicio(
                    Convert.ToInt32(datos["_IDServicio"]),
                    datos["Nombre"].ToString(),
                    datos["descripcion"].ToString()));
            }

            conecccionBD.Close();
            conecccionBD.Open();
            string querySpa = "SELECT * FROM SPA";
            cmd = new SqlCommand(querySpa, conecccionBD);
            datos = cmd.ExecuteReader();
            while (datos.Read())
            {
                Administrador.listaSpa.Add(new Spa(
                    Convert.ToInt32(datos["_IDSpa"]),
                    datos["Nombre"].ToString()));
            }

            conecccionBD.Close();
            conecccionBD.Open();
            string querySucursal = "SELECT * FROM SUCURSAL";
            cmd = new SqlCommand(querySucursal, conecccionBD);
            datos = cmd.ExecuteReader();
            while (datos.Read())
            {
                Administrador.listaSucursal.Add(new Sucursal(
                    datos["nombre"].ToString(),
                    datos["direccion"].ToString(),
                    datos["fechaApertura"].ToString(),
                    datos["horarioAtencion"].ToString(),
                    datos["empleadoAdmin"].ToString(),
                    Convert.ToInt32(datos["capacidadMax"]),
                    Convert.ToInt32(datos["numTelefono"])

                ));
            }

            conecccionBD.Close();
            conecccionBD.Open();
            string queryTipoDeEquipo = "SELECT * FROM TIPOEQUIPO";
            cmd = new SqlCommand(queryTipoDeEquipo, conecccionBD);
            datos = cmd.ExecuteReader();
            while (datos.Read())
            {
                Administrador.listaTipoEquipo.Add(new TipoDeEquipo(
                    Convert.ToInt32(datos["_IDTipoEquipo"]),
                    datos["nombre"].ToString(),
                    datos["descripcion"].ToString()));
            }

            conecccionBD.Close();
            conecccionBD.Open();
            string queryTipoPlanilla = "SELECT * FROM TIPOPLANILLA";
            cmd = new SqlCommand(queryTipoPlanilla, conecccionBD);
            datos = cmd.ExecuteReader();
            while (datos.Read())
            {
                Administrador.listaTipoPlanilla.Add(new TipoPlanilla(
                    Convert.ToInt32(datos["_IDTipoPlanilla"]),
                    datos["descripcion"].ToString(),
                    Convert.ToInt32(datos["pagoMensual"]),
                    Convert.ToInt32(datos["pagoXhora"]),
                    Convert.ToInt32(datos["pagoXclase"])
                ));
            }

            conecccionBD.Close();
            conecccionBD.Open();
            string queryUsuario = "SELECT * FROM USUARIO";
            cmd = new SqlCommand(queryUsuario, conecccionBD);
            datos = cmd.ExecuteReader();
            while (datos.Read())
            {
                Administrador.listaUsuario.Add(new Usuario(
                    Convert.ToInt32(datos["numCedula"]),
                    datos["nombre"].ToString(),
                    Convert.ToInt32(datos["edad"]),
                    datos["fechaNacimiento"].ToString(),
                    Convert.ToInt32(datos["peso"]),
                    Convert.ToInt32(datos["IMC"]),
                    datos["direccion"].ToString(),
                    datos["correoElectronico"].ToString(),
                    "123"));
            }

            conecccionBD.Close();
            conecccionBD.Open();
            string queryClases = "SELECT * FROM CLASES";
            cmd = new SqlCommand(queryClases, conecccionBD);
            datos = cmd.ExecuteReader();
            while (datos.Read())
            {
                Administrador.listaClases.Add(new Clases(
                    Convert.ToInt32(datos["idClase"]),
                    datos["tipo"].ToString(),
                    datos["instructor"].ToString(),
                    Convert.ToInt32(datos["individual"]),
                    Convert.ToInt32(datos["capacidad"]),
                    datos["fecha"].ToString(),
                    datos["horaInicio"].ToString(),
                    datos["horaFin"].ToString()));
            }

            conecccionBD.Close();
        }

        public void insertEmpleado(Empleado empleado)
        {

            string queryEmpleado =
                "INSERT INTO EMPLEADO(numCedula , nombre ,direccion ,puesto ,sucursal , _IDTipoPlanilla , salario , correoElectronico, horasTrabajadas , clasesRealizadas) VALUES(@numCedula , @nombre , @direccion , @puesto , @sucursal , @_IDTipoPlanilla , @salario , @correoElectronico, @horasTrabajadas , @clasesRealizadas)";

                SqlCommand cmd1 = new SqlCommand(queryEmpleado, conecccionBD);
                cmd1.Parameters.Add("@numCedula", SqlDbType.Int);
                cmd1.Parameters["@numCedula"].Value = empleado.numCedula;

                cmd1.Parameters.Add("@nombre", SqlDbType.VarChar);
                cmd1.Parameters["@nombre"].Value = empleado.nombre;

                cmd1.Parameters.Add("@direccion", SqlDbType.VarChar);
                cmd1.Parameters["@direccion"].Value = empleado.direccion;

                cmd1.Parameters.Add("@puesto", SqlDbType.VarChar);
                cmd1.Parameters["@puesto"].Value = empleado.puesto;

                cmd1.Parameters.Add("@sucursal", SqlDbType.VarChar);
                cmd1.Parameters["@sucursal"].Value = empleado.sucursal;

                cmd1.Parameters.Add("@_IDTipoPlanilla", SqlDbType.Int);
                cmd1.Parameters["@_IDTipoPlanilla"].Value = empleado.tipoPlanilla;

                cmd1.Parameters.Add("@salario", SqlDbType.Int);
                cmd1.Parameters["@salario"].Value = empleado.salario;

                cmd1.Parameters.Add("@correoElectronico", SqlDbType.VarChar);
                cmd1.Parameters["@correoElectronico"].Value = empleado.correoElectronico;

                cmd1.Parameters.Add("@horasTrabajadas", SqlDbType.Int);
                cmd1.Parameters["@horasTrabajadas"].Value = empleado.horasTrabajadas;

                cmd1.Parameters.Add("@clasesRealizadas", SqlDbType.Int);
                cmd1.Parameters["@clasesRealizadas"].Value = empleado.clasesRealizadas;

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd1.ExecuteNonQuery();
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            
        }

        public void updateEmpleado(Empleado empleado)
        {

            string queryEmpleado = "UPDATE EMPLEADO SET nombre = @nombre , direccion = @direccion, puesto = @puesto, sucursal = @sucursal , _IDTipoPlanilla = @_IDTipoPlanilla, salario = @salario , correoElectronico = @correoElectronico, horasTrabajadas = @horasTrabajadas, clasesRealizadas = @clasesRealizadas WHERE @numCedula = numCedula;";

                SqlCommand cmd2 = new SqlCommand(queryEmpleado, conecccionBD);
                cmd2.Parameters.Add("@numCedula", SqlDbType.Int);
                cmd2.Parameters["@numCedula"].Value = empleado.numCedula;

                cmd2.Parameters.Add("@nombre", SqlDbType.VarChar);
                cmd2.Parameters["@nombre"].Value = empleado.nombre;

                cmd2.Parameters.Add("@direccion", SqlDbType.VarChar);
                cmd2.Parameters["@direccion"].Value = empleado.direccion;

                cmd2.Parameters.Add("@puesto", SqlDbType.VarChar);
                cmd2.Parameters["@puesto"].Value = empleado.puesto;

                cmd2.Parameters.Add("@sucursal", SqlDbType.VarChar);
                cmd2.Parameters["@sucursal"].Value = empleado.sucursal;

                cmd2.Parameters.Add("@_IDTipoPlanilla", SqlDbType.Int);
                cmd2.Parameters["@_IDTipoPlanilla"].Value = empleado.tipoPlanilla;

                cmd2.Parameters.Add("@salario", SqlDbType.Int);
                cmd2.Parameters["@salario"].Value = empleado.salario;

                cmd2.Parameters.Add("@correoElectronico", SqlDbType.VarChar);
                cmd2.Parameters["@correoElectronico"].Value = empleado.correoElectronico;

                cmd2.Parameters.Add("@horasTrabajadas", SqlDbType.Int);
                cmd2.Parameters["@horasTrabajadas"].Value = empleado.horasTrabajadas;

                cmd2.Parameters.Add("@clasesRealizadas", SqlDbType.Int);
                cmd2.Parameters["@clasesRealizadas"].Value = empleado.clasesRealizadas;

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd2.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    conecccionBD.Close();
                }

        }

        public void eliminarEmpleado(Empleado empleado)
        {
            string queryEmpleado = "DELETE FROM EMPLEADO WHERE @numCedula = numCedula;";
            
                SqlCommand cmd3 = new SqlCommand(queryEmpleado, conecccionBD);
                cmd3.Parameters.Add("@numCedula", SqlDbType.Int);
                cmd3.Parameters["@numCedula"].Value = empleado.numCedula;

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd3.ExecuteNonQuery();
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

        }

        public void insertInventario(Inventario inventario)
        {

            string queryInventario = "INSERT INTO INVENTARIO(tipoMaquina ,marca ,numSerie ,costo , sucursal)" +
                                     "VALUES(@tipoMaquina, @marca, @numSerie, @costo, @sucursal)";

                SqlCommand cmd4 = new SqlCommand(queryInventario, conecccionBD);
                cmd4.Parameters.Add("@tipoMaquina", SqlDbType.VarChar);
                cmd4.Parameters["@tipoMaquina"].Value = inventario.tipoMaquina;

                cmd4.Parameters.Add("@marca", SqlDbType.VarChar);
                cmd4.Parameters["@marca"].Value = inventario.marca;

                cmd4.Parameters.Add("@numSerie", SqlDbType.Int);
                cmd4.Parameters["@numSerie"].Value = inventario.numSerie;

                cmd4.Parameters.Add("@costo", SqlDbType.Int);
                cmd4.Parameters["@costo"].Value = inventario.costo;

                cmd4.Parameters.Add("@sucursal", SqlDbType.VarChar);
                cmd4.Parameters["@sucursal"].Value = inventario.sucursal;

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd4.ExecuteNonQuery();
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

        }

        public void updateinventario(Inventario inventario)
        {

            string queryInventario = "UPDATE INVENTARIO " +
                                     "SET tipoMaquina = @tipoMaquina , marca = @marca, costo = @costo, sucursal = @sucursal " +
                                     "WHERE @numSerie = numSerie;";

                SqlCommand cmd5 = new SqlCommand(queryInventario, conecccionBD);
                cmd5.Parameters.Add("@tipoMaquina", SqlDbType.VarChar);
                cmd5.Parameters["@tipoMaquina"].Value = inventario.tipoMaquina;

                cmd5.Parameters.Add("@marca", SqlDbType.VarChar);
                cmd5.Parameters["@marca"].Value = inventario.marca;

                cmd5.Parameters.Add("@numSerie", SqlDbType.Int);
                cmd5.Parameters["@numSerie"].Value = inventario.numSerie;

                cmd5.Parameters.Add("@costo", SqlDbType.Int);
                cmd5.Parameters["@costo"].Value = inventario.costo;

                cmd5.Parameters.Add("@sucursal", SqlDbType.VarChar);
                cmd5.Parameters["@sucursal"].Value = inventario.sucursal;

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd5.ExecuteNonQuery();
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

        }
        
        public void eliminarInventario(Inventario inventario)
        {
            string queryInventario = "DELETE FROM INVENTARIO " +
                                     "WHERE @numSerie = numSerie;";
            
                SqlCommand cmd6 = new SqlCommand(queryInventario, conecccionBD);
                cmd6.Parameters.Add("@numSerie", SqlDbType.Int);
                cmd6.Parameters["@numSerie"].Value = inventario.numSerie;

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd6.ExecuteNonQuery();
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

        }
        
        public void insertPuesto(Puesto puesto)
        {

            string queryPuesto= "INSERT INTO PUESTO(_IDPuesto , NombrePuesto, descripcion) " +
                                "VALUES(@_IDPuesto, @NombrePuesto , @descripcion)";

                SqlCommand cmd7 = new SqlCommand(queryPuesto, conecccionBD);

                cmd7.Parameters.Add("@_IDPuesto", SqlDbType.Int);
                cmd7.Parameters["@_IDPuesto"].Value = puesto.idPuesto;
                
                cmd7.Parameters.Add("@NombrePuesto", SqlDbType.VarChar);
                cmd7.Parameters["@NombrePuesto"].Value = puesto.nombre;

                cmd7.Parameters.Add("@descripcion", SqlDbType.VarChar);
                cmd7.Parameters["@descripcion"].Value = puesto.descripcion;

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd7.ExecuteNonQuery();
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
          
        }

        public void UpdatePuesto(Puesto puesto)
        {

            string queryPuesto= "UPDATE PUESTO " +
                                "SET _IDPuesto = @_IDPuesto , descripcion = @descripcion " +
                                "WHERE @NombrePuesto = NombrePuesto;";

             SqlCommand cmd8 = new SqlCommand(queryPuesto, conecccionBD);

                cmd8.Parameters.Add("@_IDPuesto", SqlDbType.Int);
                cmd8.Parameters["@_IDPuesto"].Value = puesto.idPuesto;
                
                cmd8.Parameters.Add("@NombrePuesto", SqlDbType.VarChar);
                cmd8.Parameters["@NombrePuesto"].Value = puesto.nombre;

                cmd8.Parameters.Add("@descripcion", SqlDbType.VarChar);
                cmd8.Parameters["@descripcion"].Value = puesto.descripcion;

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd8.ExecuteNonQuery();
                    conecccionBD.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
           
        }
        public void eliminarPuesto(Puesto puesto)
        {
            string queryPuesto = "DELETE FROM PUESTO " +
                                     "WHERE @NombrePuesto = NombrePuesto;";
            
                SqlCommand cmd9 = new SqlCommand(queryPuesto, conecccionBD);
                cmd9.Parameters.Add("@NombrePuesto", SqlDbType.VarChar);
                cmd9.Parameters["@NombrePuesto"].Value = puesto.nombre;

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd9.ExecuteNonQuery();
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

        }
        
        public void insertProducto(Producto producto)
        {

            string queryProducto= "INSERT INTO PRODUCTO(nombre , codigoBarras , descripcion , costo, nombreSucursal) " +
                                  "VALUES(@nombre, @codigoBarras, @descripcion, @costo, @nombreSucursal)";

           
                SqlCommand cmd10 = new SqlCommand(queryProducto, conecccionBD);
                cmd10.Parameters.Add("@nombre", SqlDbType.VarChar);
                cmd10.Parameters["@nombre"].Value = producto.nombre;

                cmd10.Parameters.Add("@codigoBarras", SqlDbType.Int);
                cmd10.Parameters["@codigoBarras"].Value = producto.codigoBarras;

                
                cmd10.Parameters.Add("@descripcion", SqlDbType.VarChar);
                cmd10.Parameters["@descripcion"].Value = producto.descripcion;

                cmd10.Parameters.Add("@costo", SqlDbType.Int);
                cmd10.Parameters["@costo"].Value = producto.costo;
                
                cmd10.Parameters.Add("@nombreSucursal", SqlDbType.VarChar);
                cmd10.Parameters["@nombreSucursal"].Value = "GYMTEC";

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd10.ExecuteNonQuery();
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
          
        }
        public void updateProducto(Producto producto)
        {

            string queryProducto= "UPDATE PRODUCTO " +
                                  "SET nombre = @nombre , descripcion = @descripcion , costo = @costo " +
                                  "WHERE @codigoBarras = codigoBarras;";

                SqlCommand cmd11 = new SqlCommand(queryProducto, conecccionBD);
                cmd11.Parameters.Add("@nombre", SqlDbType.VarChar);
                cmd11.Parameters["@nombre"].Value = producto.nombre;

                cmd11.Parameters.Add("@codigoBarras", SqlDbType.Int);
                cmd11.Parameters["@codigoBarras"].Value = producto.codigoBarras;

                
                cmd11.Parameters.Add("@descripcion", SqlDbType.VarChar);
                cmd11.Parameters["@descripcion"].Value = producto.descripcion;

                cmd11.Parameters.Add("@costo", SqlDbType.Int);
                cmd11.Parameters["@costo"].Value = producto.costo;
                
                cmd11.Parameters.Add("@nombreSucursal", SqlDbType.VarChar);
                cmd11.Parameters["@nombreSucursal"].Value = "GYMTEC";

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd11.ExecuteNonQuery();
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
          
        }
        public void eliminarProducto(Producto producto)
        {
            string queryproducto = "DELETE FROM PRODUCTO " +
                                   "WHERE @codigoBarras = codigoBarras;";
             SqlCommand cmd12 = new SqlCommand(queryproducto, conecccionBD);
                cmd12.Parameters.Add("@codigoBarras", SqlDbType.Int);
                cmd12.Parameters["@codigoBarras"].Value = producto.codigoBarras;

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd12.ExecuteNonQuery();
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            
        }
        
        public void insertServicio(Servicio servicio)
        {

            string queryServicio= "INSERT INTO SERVICIO( _IDServicio , Nombre, descripcion , nombreSucursal)" +
                                  "VALUES(@_IDServicio, @Nombre , @descripcion , @nombreSucursal)";

             SqlCommand cmd13 = new SqlCommand(queryServicio, conecccionBD);
                cmd13.Parameters.Add("@_IDServicio", SqlDbType.Int);
                cmd13.Parameters["@_IDServicio"].Value = servicio.idServicio;

                cmd13.Parameters.Add("@Nombre", SqlDbType.VarChar);
                cmd13.Parameters["@Nombre"].Value = servicio.nombreServicio;

                cmd13.Parameters.Add("@descripcion", SqlDbType.VarChar);
                cmd13.Parameters["@descripcion"].Value = servicio.descripcion;
                
                cmd13.Parameters.Add("@nombreSucursal", SqlDbType.VarChar);
                cmd13.Parameters["@nombreSucursal"].Value = "GYMTEC";

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd13.ExecuteNonQuery();
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                

        }
        
        public void updateServicio(Servicio servicio)
        {

            string queryServicio= "UPDATE SERVICIO " +
                                  "SET Nombre = @Nombre , descripcion = @descripcion , nombreSucursal = @nombreSucursal " +
                                  "WHERE @_IDServicio = _IDServicio;";

                SqlCommand cmd14 = new SqlCommand(queryServicio, conecccionBD);
                cmd14.Parameters.Add("@_IDServicio", SqlDbType.Int);
                cmd14.Parameters["@_IDServicio"].Value = servicio.idServicio;

                cmd14.Parameters.Add("@Nombre", SqlDbType.VarChar);
                cmd14.Parameters["@Nombre"].Value = servicio.nombreServicio;

                cmd14.Parameters.Add("@descripcion", SqlDbType.VarChar);
                cmd14.Parameters["@descripcion"].Value = servicio.descripcion;
                
                cmd14.Parameters.Add("@nombreSucursal", SqlDbType.VarChar);
                cmd14.Parameters["@nombreSucursal"].Value = "GYMTEC";

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd14.ExecuteNonQuery();
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                


        }
        public void eliminarServicio(Servicio servicio)
        {
            string queryServicio = "DELETE FROM SERVICIO " +
                                   "WHERE @_IDServicio = _IDServicio;";
            
                SqlCommand cmd15 = new SqlCommand(queryServicio, conecccionBD);
                cmd15.Parameters.Add("@_IDServicio", SqlDbType.Int);
                cmd15.Parameters["@_IDServicio"].Value = servicio.idServicio;

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd15.ExecuteNonQuery();
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                

        }
        
        public void insertClases(Clases clases)
        {

            string queryClases= "INSERT INTO CLASES(idClase, tipo, instructor, individual, capacidad, fecha, horaInicio, horaFin , nombreSucursal)" +
                                "VALUES(@idClase, @tipo, @instructor, @individual, @capacidad, @fecha, @horaInicio, @horaFin , @nombreSucursal)";

                SqlCommand cmd = new SqlCommand(queryClases, conecccionBD);

                cmd.Parameters.Add("@idClase", SqlDbType.Int);
                cmd.Parameters["@idClase"].Value = clases.idClase;

                cmd.Parameters.Add("@tipo", SqlDbType.VarChar);
                cmd.Parameters["@tipo"].Value = clases.tipo;

                cmd.Parameters.Add("@instructor", SqlDbType.VarChar);
                cmd.Parameters["@instructor"].Value = clases.instructor;

                cmd.Parameters.Add("@individual", SqlDbType.Int);
                cmd.Parameters["@individual"].Value = clases.individual;

                cmd.Parameters.Add("@capacidad", SqlDbType.Int);
                cmd.Parameters["@capacidad"].Value = clases.capacidad;

                cmd.Parameters.Add("@fecha", SqlDbType.VarChar);
                cmd.Parameters["@fecha"].Value = clases.fecha;

                cmd.Parameters.Add("@horaInicio", SqlDbType.VarChar);
                cmd.Parameters["@horaInicio"].Value = clases.horaInicio;

                cmd.Parameters.Add("@horaFin", SqlDbType.VarChar);
                cmd.Parameters["@horaFin"].Value = clases.horaFin;
                
                cmd.Parameters.Add("@nombreSucursal", SqlDbType.VarChar);
                cmd.Parameters["@nombreSucursal"].Value = "GymTEC";

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

        }
        public void updateClases(Clases clases)
        {

            string queryClases= "UPDATE CLASES " +
                                "SET idClase = @idClase , instructor = @instructor , individual = @individual , capacidad = @capacidad , fecha = @fecha , horaInicio = @horaInicio , horaFin = @horaFin " +
                                "WHERE @tipo = tipo;";
                SqlCommand cmd = new SqlCommand(queryClases, conecccionBD);

                cmd.Parameters.Add("@idClase", SqlDbType.Int);
                cmd.Parameters["@idClase"].Value = clases.idClase;

                cmd.Parameters.Add("@tipo", SqlDbType.VarChar);
                cmd.Parameters["@tipo"].Value = clases.tipo;

                cmd.Parameters.Add("@instructor", SqlDbType.VarChar);
                cmd.Parameters["@instructor"].Value = clases.instructor;

                cmd.Parameters.Add("@individual", SqlDbType.Int);
                cmd.Parameters["@individual"].Value = clases.individual;

                cmd.Parameters.Add("@capacidad", SqlDbType.Int);
                cmd.Parameters["@capacidad"].Value = clases.capacidad;

                cmd.Parameters.Add("@fecha", SqlDbType.VarChar);
                cmd.Parameters["@fecha"].Value = clases.fecha;

                cmd.Parameters.Add("@horaInicio", SqlDbType.VarChar);
                cmd.Parameters["@horaInicio"].Value = clases.horaInicio;

                cmd.Parameters.Add("@horaFin", SqlDbType.VarChar);
                cmd.Parameters["@horaFin"].Value = clases.horaFin;

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

        }
        public void eliminarClases(Clases clases)
        {
            string queryClases = "DELETE FROM CLASES " +
                                "WHERE @tipo = tipo;";
            
            SqlCommand cmd15 = new SqlCommand(queryClases, conecccionBD);
            cmd15.Parameters.Add("@tipo", SqlDbType.Int);
            cmd15.Parameters["@tipo"].Value = clases.tipo;

            try
            {
                conecccionBD.Open();
                Int32 rowsAffected = cmd15.ExecuteNonQuery();
                conecccionBD.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        public void insertSpa(Spa spa)
        {

            string querySpa= "INSERT INTO SPA( _IDSpa , Nombre , nombreSucursal)" +
                             "VALUES(@IDSpa, @Nombre , @nombreSucursal)";

            using (conecccionBD)
            {
                SqlCommand cmd = new SqlCommand(querySpa, conecccionBD);

                cmd.Parameters.Add("@IDSpa", SqlDbType.Int);
                cmd.Parameters["@IDSpa"].Value = spa.idSpa;

                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                cmd.Parameters["@Nombre"].Value = spa.nombre;
                
                cmd.Parameters.Add("@nombreSucursal", SqlDbType.VarChar);
                cmd.Parameters["@nombreSucursal"].Value = "GymTEC";

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                conecccionBD.Close();


            }
        }
        public void updateSpa(Spa spa)
        {

            string querySpa= "UPDATE SPA " +
                             "SET Nombre = @Nombre , nombreSucursal = @nombreSucursal  " +
                             "WHERE @_IDSpa = _IDSpa;";

            using (conecccionBD)
            {
                SqlCommand cmd = new SqlCommand(querySpa, conecccionBD);

                cmd.Parameters.Add("@_IDSpa", SqlDbType.Int);
                cmd.Parameters["@_IDSpa"].Value = spa.idSpa;

                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                cmd.Parameters["@Nombre"].Value = spa.nombre;
                
                cmd.Parameters.Add("@nombreSucursal", SqlDbType.VarChar);
                cmd.Parameters["@nombreSucursal"].Value = "GymTEC";

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                conecccionBD.Close();


            }
        }
        public void eliminarSpa(Spa spa)
        {

            string querySpa= "DELETE FROM SPA " +
                             "WHERE @_IDSpa = _IDSpa;";

            using (conecccionBD)
            {
                SqlCommand cmd = new SqlCommand(querySpa, conecccionBD);

                cmd.Parameters.Add("@_IDSpa", SqlDbType.Int);
                cmd.Parameters["@_IDSpa"].Value = spa.idSpa;

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                conecccionBD.Close();


            }
        }
        
     public void insertSucursal(Sucursal sucursal)
        {
            
            string querySucursal= "INSERT INTO SUCURSAL(nombre , direccion , fechaApertura , horarioAtencion , empleadoAdmin , capacidadMax , numTelefono , spa, tienda)" +
                                  "VALUES(@nombre, @direccion, @fechaApertura, @horarioAtencion, @empleadoAdmin, @capacidadMax, @numTelefono, @spa, @tienda)";

           
                SqlCommand cmd = new SqlCommand(querySucursal, conecccionBD);

                cmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                cmd.Parameters["@nombre"].Value = sucursal.nombre;

                cmd.Parameters.Add("@direccion", SqlDbType.VarChar);
                cmd.Parameters["@direccion"].Value = sucursal.direccion;

                cmd.Parameters.Add("@fechaApertura", SqlDbType.VarChar);
                cmd.Parameters["@fechaApertura"].Value = sucursal.fechaApertura;

                cmd.Parameters.Add("@horarioAtencion", SqlDbType.VarChar);
                cmd.Parameters["@horarioAtencion"].Value = sucursal.horarioAtencion;

                cmd.Parameters.Add("@empleadoAdmin", SqlDbType.VarChar);
                cmd.Parameters["@empleadoAdmin"].Value = sucursal.empleadoAdmin;

                cmd.Parameters.Add("@capacidadMax", SqlDbType.Int);
                cmd.Parameters["@capacidadMax"].Value = sucursal.capacidadMax;

                cmd.Parameters.Add("@numTelefono", SqlDbType.Int);
                cmd.Parameters["@numTelefono"].Value = sucursal.numTelefono;

                cmd.Parameters.Add("@spa", SqlDbType.VarChar);
                cmd.Parameters["@spa"].Value = sucursal.spa;

                cmd.Parameters.Add("@tienda", SqlDbType.VarChar);
                cmd.Parameters["@tienda"].Value = sucursal.tienda;

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
           
        }
        
     public void updateSucursal(Sucursal sucursal)
        {
            
            string querySucursal= "UPDATE SUCURSAL " +
                                  "SET direccion = @direccion , fechaApertura = @fechaApertura , horarioAtencion = @horarioAtencion, empleadoAdmin = @empleadoAdmin, capacidadMax = @capacidadMax, numTelefono = @numTelefono, spa = @spa, tienda = @tienda   " +
                                  "WHERE @nombre = nombre;";
           
                SqlCommand cmd = new SqlCommand(querySucursal, conecccionBD);

                cmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                cmd.Parameters["@nombre"].Value = sucursal.nombre;

                cmd.Parameters.Add("@direccion", SqlDbType.VarChar);
                cmd.Parameters["@direccion"].Value = sucursal.direccion;

                cmd.Parameters.Add("@fechaApertura", SqlDbType.VarChar);
                cmd.Parameters["@fechaApertura"].Value = sucursal.fechaApertura;

                cmd.Parameters.Add("@horarioAtencion", SqlDbType.VarChar);
                cmd.Parameters["@horarioAtencion"].Value = sucursal.horarioAtencion;

                cmd.Parameters.Add("@empleadoAdmin", SqlDbType.VarChar);
                cmd.Parameters["@empleadoAdmin"].Value = sucursal.empleadoAdmin;

                cmd.Parameters.Add("@capacidadMax", SqlDbType.Int);
                cmd.Parameters["@capacidadMax"].Value = sucursal.capacidadMax;

                cmd.Parameters.Add("@numTelefono", SqlDbType.Int);
                cmd.Parameters["@numTelefono"].Value = sucursal.numTelefono;

                cmd.Parameters.Add("@spa", SqlDbType.VarChar);
                cmd.Parameters["@spa"].Value = sucursal.spa;

                cmd.Parameters.Add("@tienda", SqlDbType.VarChar);
                cmd.Parameters["@tienda"].Value = sucursal.tienda;

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
           
        }
        
        public void eliminarSucursal(Sucursal sucursal)
        {
            
            string querySucursal= "DELETE FROM SUCURSAL " +
                                  "WHERE @nombre = nombre;";
           
                SqlCommand cmd = new SqlCommand(querySucursal, conecccionBD);

                cmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                cmd.Parameters["@nombre"].Value = sucursal.nombre;

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
           
        }
        
        public void insertTipoDeEquipo(TipoDeEquipo tipoEquipo)
        {

            string queryTipoDeEquipo= "INSERT INTO TIPOEQUIPO(_IDTipoEquipo, nombre , descripcion)" +
                                      "VALUES(@id_tipoEquipo, @nombre , @descripcion)";

           
                SqlCommand cmd = new SqlCommand(queryTipoDeEquipo, conecccionBD);

                cmd.Parameters.Add("@id_tipoEquipo", SqlDbType.Int);
                cmd.Parameters["@id_tipoEquipo"].Value = tipoEquipo.idTipoEquipo;

                cmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                cmd.Parameters["@nombre"].Value = tipoEquipo.nombreTipoEquipo;
                
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
                cmd.Parameters["@descripcion"].Value = tipoEquipo.descripcion;

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
          
        }
        public void updateTipoDeEquipo(TipoDeEquipo tipoEquipo)
        {

            string queryTipoDeEquipo= "UPDATE TIPOEQUIPO " +
                                      "SET nombre = @nombre , descripcion = @descripcion " +
                                      "WHERE @_IDTipoEquipo = _IDTipoEquipo;";
            
                SqlCommand cmd = new SqlCommand(queryTipoDeEquipo, conecccionBD);

                cmd.Parameters.Add("@_IDTipoEquipo ", SqlDbType.Int);
                cmd.Parameters["@_IDTipoEquipo "].Value = tipoEquipo.idTipoEquipo;

                cmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                cmd.Parameters["@nombre"].Value = tipoEquipo.nombreTipoEquipo;
                
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
                cmd.Parameters["@descripcion"].Value = tipoEquipo.descripcion;

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                

        }
        public void eliminarTipoDeEquipo(TipoDeEquipo tipoEquipo)
        {

            string queryTipoDeEquipo= "DELETE FROM TIPOEQUIPO " +
                                      "WHERE @_IDTipoEquipo = _IDTipoEquipo;";

                SqlCommand cmd = new SqlCommand(queryTipoDeEquipo, conecccionBD);

                cmd.Parameters.Add("@_IDTipoEquipo ", SqlDbType.Int);
                cmd.Parameters["@_IDTipoEquipo "].Value = tipoEquipo.idTipoEquipo;

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                


            
        }
        
        public void insertTipoPlanilla(TipoPlanilla tipoPlanilla)
        {

            string queryTipoPlanilla= "INSERT INTO TIPOPLANILLA(_IDTipoPlanilla , descripcion, pagoMensual, pagoXhora, pagoXclase)" +
                                      "VALUES(@_IDTipoPlanilla, @descripcion, @pagoMensual, @pagoXhora, @pagoXclase)";

                SqlCommand cmd = new SqlCommand(queryTipoPlanilla, conecccionBD);

                cmd.Parameters.Add("@_IDTipoPlanilla", SqlDbType.Int);
                cmd.Parameters["@_IDTipoPlanilla"].Value = tipoPlanilla.idTipoPlanilla;

                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
                cmd.Parameters["@descripcion"].Value = tipoPlanilla.descripcion;

                cmd.Parameters.Add("@pagoMensual", SqlDbType.Int);
                cmd.Parameters["@pagoMensual"].Value = tipoPlanilla.pagoMensual;

                cmd.Parameters.Add("@pagoXhora", SqlDbType.Int);
                cmd.Parameters["@pagoXhora"].Value = tipoPlanilla.pagoXhora;

                cmd.Parameters.Add("@pagoXclase", SqlDbType.Int);
                cmd.Parameters["@pagoXclase"].Value = tipoPlanilla.pagoXclase;

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                

        }
        public void updateTipoPlanilla(TipoPlanilla tipoPlanilla)
        {

            string queryTipoPlanilla= "UPDATE TIPOPLANILLA " +
                                      "SET descripcion = @descripcion , pagoMensual = @pagoMensual , pagoXhora = @pagoXhora , pagoXclase = @pagoXclase  " +
                                      "WHERE @_IDTipoPlanilla = _IDTipoPlanilla;";
            
            
                SqlCommand cmd = new SqlCommand(queryTipoPlanilla, conecccionBD);

                cmd.Parameters.Add("@_IDTipoPlanilla", SqlDbType.Int);
                cmd.Parameters["@_IDTipoPlanilla"].Value = tipoPlanilla.idTipoPlanilla;

                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
                cmd.Parameters["@descripcion"].Value = tipoPlanilla.descripcion;

                cmd.Parameters.Add("@pagoMensual", SqlDbType.Int);
                cmd.Parameters["@pagoMensual"].Value = tipoPlanilla.pagoMensual;

                cmd.Parameters.Add("@pagoXhora", SqlDbType.Int);
                cmd.Parameters["@pagoXhora"].Value = tipoPlanilla.pagoXhora;

                cmd.Parameters.Add("@pagoXclase", SqlDbType.Int);
                cmd.Parameters["@pagoXclase"].Value = tipoPlanilla.pagoXclase;

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                


            
        }
        public void EliminarTipoPlanilla(TipoPlanilla tipoPlanilla)
        {

            string queryTipoPlanilla= "DELETE FROM TIPOPLANILLA " +
                                      "WHERE @_IDTipoPlanilla = _IDTipoPlanilla;";
            
                SqlCommand cmd = new SqlCommand(queryTipoPlanilla, conecccionBD);

                cmd.Parameters.Add("@_IDTipoPlanilla", SqlDbType.Int);
                cmd.Parameters["@_IDTipoPlanilla"].Value = tipoPlanilla.idTipoPlanilla;

                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                


        }
        
       public void insertUsuario(Usuario usuario)
        {
            
            string queryUsuario= "INSERT INTO USUARIO(numCedula, nombre, edad, fechaNacimiento, peso, IMC, direccion, correoElectronico)" +
                                  "VALUES(@numCedula, @nombre, @edad, @fechaNacimiento, @peso, @IMC, @direccion, @correoElectronico)";

                SqlCommand cmd = new SqlCommand(queryUsuario, conecccionBD);

                 cmd.Parameters.Add("@numCedula", SqlDbType.Int);
                cmd.Parameters["@numCedula"].Value = usuario.numCedula;

                cmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                cmd.Parameters["@nombre"].Value = usuario.nombre;

                cmd.Parameters.Add("@edad", SqlDbType.Int);
                cmd.Parameters["@edad"].Value = usuario.edad;

                cmd.Parameters.Add("@fechaNacimiento", SqlDbType.VarChar);
                cmd.Parameters["@fechaNacimiento"].Value = usuario.fechaNacimiento;

                cmd.Parameters.Add("@peso", SqlDbType.Int);
                cmd.Parameters["@peso"].Value = usuario.peso;

                cmd.Parameters.Add("@IMC", SqlDbType.Int);
                cmd.Parameters["@IMC"].Value = usuario.IMC;

                cmd.Parameters.Add("@direccion", SqlDbType.VarChar);
                cmd.Parameters["@direccion"].Value = usuario.direccion;

                cmd.Parameters.Add("@correoElectronico", SqlDbType.VarChar);
                cmd.Parameters["@correoElectronico"].Value = usuario.correoElectronico;
                try
                {
                    conecccionBD.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    conecccionBD.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
    
        } 
        
        
        
        
        
    }
}