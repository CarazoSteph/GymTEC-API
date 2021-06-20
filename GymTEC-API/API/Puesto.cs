namespace GymTEC_API.DB
{
    public class Puesto
    {
        //atributtes
        public string id_puesto;
        public string descripcion;

        //contructor
        public Puesto(string idPuesto, string descripcion)
        {
            id_puesto = idPuesto;
            this.descripcion = descripcion;
        }

        //getters and setters
        public string IdPuesto
        {
            get => id_puesto;
            set => id_puesto = value;
        }

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
    }
}