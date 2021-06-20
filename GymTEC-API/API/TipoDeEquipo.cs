namespace GymTEC_API.DB
{
    public class TipoDeEquipo
    {
        //attributes
        public string id_tipoEquipo;
        public string descripcion;

        //constructor
        public TipoDeEquipo(string idTipoEquipo, string descripcion)
        {
            id_tipoEquipo = idTipoEquipo;
            this.descripcion = descripcion;
        }

        //getters and setters
        public string IdTipoEquipo
        {
            get => id_tipoEquipo;
            set => id_tipoEquipo = value;
        }

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
    }
}