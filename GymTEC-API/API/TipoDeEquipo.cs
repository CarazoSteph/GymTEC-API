namespace GymTEC_API.DB
{
    public class TipoDeEquipo
    {
        //attributes
        public int idTipoEquipo;
        public string nombreTipoEquipo;
        public string descripcion;

        //constructor
        public TipoDeEquipo(int idTipoEquipo, string nombreTipoEquipo, string descripcion)
        {
            this.idTipoEquipo = idTipoEquipo;
            this.nombreTipoEquipo = nombreTipoEquipo;
            this.descripcion = descripcion;
        }

        //getters and setters
        public int IdTipoEquipo
        {
            get => idTipoEquipo;
            set => idTipoEquipo = value;
        }
        public string NombreTipoEquipo
        {
            get => nombreTipoEquipo;
            set => nombreTipoEquipo = value;
        }
        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }
    }
}