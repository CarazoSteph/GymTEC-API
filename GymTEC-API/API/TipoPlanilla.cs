namespace GymTEC_API.DB
{
    public class TipoPlanilla
    {
        //atributtes
        public string pagoMensual;
        public string pagoXhora;
        public string pagoXclase;

        //constructor
        public TipoPlanilla(string pagoMensual, string pagoXhora, string pagoXclase)
        {
            this.pagoMensual = pagoMensual;
            this.pagoXhora = pagoXhora;
            this.pagoXclase = pagoXclase;
        }

        //getters snd setters
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