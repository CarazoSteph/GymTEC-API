namespace GymTEC_API.DB
{
    public class Puesto
    {
        //atributtes
        public int idPuesto;
        public string nombre;
        public string descripcion;

        //contructor
        public Puesto(int idPuesto, string nombre, string descripcion)
        {
            this.idPuesto = idPuesto;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        //getters and setters
        public int IdPuesto
        {
            get => idPuesto;
            set => idPuesto = value;
        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
    }
}