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
        }

        //getters and setters
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