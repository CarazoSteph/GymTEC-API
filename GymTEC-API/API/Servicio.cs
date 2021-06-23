namespace GymTEC_API.DB
{
    public class Servicio
    {
        //atributtes
        public int idServicio;
        public string nombreServicio;
        public string descripcion;

        //constructor
        public Servicio(int idServicio, string nombreServicio, string descripcion)
        {
            this.idServicio = idServicio;
            this.nombreServicio = nombreServicio;
            this.descripcion = descripcion;
        }

        //getters and setters
        public int IdServicio
        {
            get => idServicio;
            set => idServicio = value;
        }
        public string NombreServicio
        {
            get => nombreServicio;
            set => nombreServicio = value;
        }

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
    }
}