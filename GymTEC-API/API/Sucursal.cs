using System.Collections.Generic;

namespace GymTEC_API.DB
{
    public class Sucursal
    {
        //atributtes
        public string nombre;
        public string direccion;
        public string fechaApertura;
        public string horarioAtencion;
        public string empleadoAdmin;
        public int capacidadMax;
        public int numTelefono;
        public string spa;
        public string tienda;
        public IList<Spa> listaSpas;
        public IList<Producto> listaproductos;
        public IList<Inventario> ListaInventario;
        public IList<Servicio> ListaServicios;
        

        //contructor
        public Sucursal(string nombre, string direccion, string fechaApertura, string horarioAtencion, string empleadoAdmin, int capacidadMax, int numTelefono)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.fechaApertura = fechaApertura;
            this.horarioAtencion = horarioAtencion;
            this.empleadoAdmin = empleadoAdmin;
            this.capacidadMax = capacidadMax;
            this.numTelefono = numTelefono;
            this.spa =  "off";
            this.tienda = "off";
            this.listaSpas = new List<Spa>();
            this.listaproductos = new List<Producto>();
            this.ListaInventario = new List<Inventario>();
            this.ListaServicios = new List<Servicio>();
        }

        //getters and setters
        public IList<Spa> ListaSpas
        {
            get => listaSpas;
            set => listaSpas = value;
        }

        public IList<Producto> Listaproductos
        {
            get => listaproductos;
            set => listaproductos = value;
        }

        public IList<Inventario> ListaInventario1
        {
            get => ListaInventario;
            set => ListaInventario = value;
        }

        public IList<Servicio> ListaServicios1
        {
            get => ListaServicios;
            set => ListaServicios = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Direccion
        {
            get => direccion;
            set => direccion = value;
        }

        public string FechaApertura
        {
            get => fechaApertura;
            set => fechaApertura = value;
        }

        public string HorarioAtencion
        {
            get => horarioAtencion;
            set => horarioAtencion = value;
        }

        public string EmpleadoAdmin
        {
            get => empleadoAdmin;
            set => empleadoAdmin = value;
        }

        public int CapacidadMax
        {
            get => capacidadMax;
            set => capacidadMax = value;
        }

        public int NumTelefono
        {
            get => numTelefono;
            set => numTelefono = value;
        }

        public string Spa
        {
            get => spa;
            set => spa = value;
        }

        public string Tienda
        {
            get => tienda;
            set => tienda = value;
        }
    }
}