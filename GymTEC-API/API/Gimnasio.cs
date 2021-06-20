namespace GymTEC_API.DB
{
    public class Gimnasio
    {
        //attributes
        public string nombre_gimnasio;
        public string descripcion;

        //constructor
        public Gimnasio(string nombreGimnasio, string descripcion)
        {
            nombre_gimnasio = nombreGimnasio;
            this.descripcion = descripcion;
        }

        //getters and setters
        public string NombreGimnasio
        {
            get => nombre_gimnasio;
            set => nombre_gimnasio = value;
        }

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
    }
}