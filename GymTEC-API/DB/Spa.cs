namespace GymTEC_API.DB
{
    public class Spa
    {
        //atributtes
        public string masajeRelajante;
        public string masajeDescargaMuscular;
        public string sauna;
        public string banosVapor;

        //constructor
        public Spa(string masajeRelajante, string masajeDescargaMuscular, string sauna, string banosVapor)
        {
            this.masajeRelajante = masajeRelajante;
            this.masajeDescargaMuscular = masajeDescargaMuscular;
            this.sauna = sauna;
            this.banosVapor = banosVapor;
        }

        //getters and setters
        public string MasajeRelajante
        {
            get => masajeRelajante;
            set => masajeRelajante = value;
        }

        public string MasajeDescargaMuscular
        {
            get => masajeDescargaMuscular;
            set => masajeDescargaMuscular = value;
        }

        public string Sauna
        {
            get => sauna;
            set => sauna = value;
        }

        public string BanosVapor
        {
            get => banosVapor;
            set => banosVapor = value;
        }
    }
}