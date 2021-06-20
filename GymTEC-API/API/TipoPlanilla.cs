namespace GymTEC_API.DB
{
    public class TipoPlanilla
    {
        //atributtes
        public int id_TipoPlanilla;
        public string descripcion;
        public string pagoMensual;
        public string pagoXhora;
        public string pagoXclase;

        //constructor
        public TipoPlanilla(string pagoMensual, string pagoXhora, string pagoXclase, int id_TipoPlanilla , string descripcion)
        {
            this.id_TipoPlanilla = id_TipoPlanilla;
            this.descripcion = descripcion;
            this.pagoMensual = pagoMensual;
            this.pagoXhora = pagoXhora;
            this.pagoXclase = pagoXclase;
        }

        //getters snd setters
        public int IdTipoPlanilla
        {
            get => id_TipoPlanilla;
            set => id_TipoPlanilla = value;
        }

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }

        public string PagoMensual
        {
            get => pagoMensual;
            set => pagoMensual = value;
        }

        public string PagoXhora
        {
            get => pagoXhora;
            set => pagoXhora = value;
        }

        public string PagoXclase
        {
            get => pagoXclase;
            set => pagoXclase = value;
        }
    }
}