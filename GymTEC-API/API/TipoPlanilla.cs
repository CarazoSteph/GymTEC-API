namespace GymTEC_API.DB
{
    public class TipoPlanilla
    {
        //atributtes
        public int idTipoPlanilla;
        public string descripcion;
        public int pagoMensual;
        public int pagoXhora;
        public int pagoXclase;

        //constructor
        public TipoPlanilla(int idTipoPlanilla , string descripcion, int pagoMensual, int pagoXhora, int pagoXclase)
        {
            this.idTipoPlanilla = idTipoPlanilla;
            this.descripcion = descripcion;
            this.pagoMensual = pagoMensual;
            this.pagoXhora = pagoXhora;
            this.pagoXclase = pagoXclase;
        }

        //getters snd setters
        public int IdTipoPlanilla
        {
            get => idTipoPlanilla;
            set => idTipoPlanilla = value;
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