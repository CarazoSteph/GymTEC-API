namespace GymTEC_API.DB
{
    public class Spa
    {
        //atributtes
        public int idSpa;
        public string nombre;

        //constructor
        public Spa(int idSpa, string nombre)
        {
            this.idSpa = idSpa;
            this.nombre = nombre;
        }

        //getters and setters
        public int IdSpa
        {
            get => idSpa;
            set => idSpa = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
    }
}