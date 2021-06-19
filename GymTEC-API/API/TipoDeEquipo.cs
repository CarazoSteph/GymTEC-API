namespace GymTEC_API.DB
{
    public class TipoDeEquipo
    {
        //attributes
        public string cintasCorrer;
        public string bicicletasEstacionarias;
        public string multigimnasios;
        public string remos;
        public string pesas;

        //constructor
        public TipoDeEquipo(string cintasCorrer, string bicicletasEstacionarias, string multigimnasios, string remos, string pesas)
        {
            this.cintasCorrer = cintasCorrer;
            this.bicicletasEstacionarias = bicicletasEstacionarias;
            this.multigimnasios = multigimnasios;
            this.remos = remos;
            this.pesas = pesas;
        }

        //getters and setters
        public string CintasCorrer
        {
            get => cintasCorrer;
            set => cintasCorrer = value;
        }

        public string BicicletasEstacionarias
        {
            get => bicicletasEstacionarias;
            set => bicicletasEstacionarias = value;
        }

        public string Multigimnasios
        {
            get => multigimnasios;
            set => multigimnasios = value;
        }

        public string Remos
        {
            get => remos;
            set => remos = value;
        }

        public string Pesas
        {
            get => pesas;
            set => pesas = value;
        }
    }
}