namespace GymTEC_API.DB
{
    public class TipoPlanilla
    {
        //atributtes
        public int id_TipoPlanilla;
        public string descripcion;
        public int pagoMensual;
        public int pagoXhora;
        public int pagoXclase;

        //constructor
        public TipoPlanilla(int pagoMensual, int pagoXhora, int pagoXclase, int id_TipoPlanilla , string descripcion)
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

        public int PagoMensual
        {
            get => pagoMensual;
            set => pagoMensual = value;
        }

        public int PagoXhora
        {
            get => pagoXhora;
            set => pagoXhora = value;
        }

        public int PagoXclase
        {
            get => pagoXclase;
            set => pagoXclase = value;
        }
    }
}