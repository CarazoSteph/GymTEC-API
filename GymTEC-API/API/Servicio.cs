namespace GymTEC_API.DB
{
    public class Servicio
    {
        //atributtes
        public string nombre_servicio;
        public string descripcion;

        //constructor
        public Servicio(string nombreServicio, string descripcion)
        {
            nombre_servicio = nombreServicio;
            this.descripcion = descripcion;
        }

        //getters and setters
        public string NombreServicio
        {
            get => nombre_servicio;
            set => nombre_servicio = value;
        }

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
    }
}