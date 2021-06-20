namespace GymTEC_API.DB
{
    public class Spa
    {
        //atributtes
        public string id_spa;
        public string nombre;

        //constructor
        public Spa(string idSpa, string nombre)
        {
            id_spa = idSpa;
            this.nombre = nombre;
        }

        //getters and setters
        public string IdSpa
        {
            get => id_spa;
            set => id_spa = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
    }
}