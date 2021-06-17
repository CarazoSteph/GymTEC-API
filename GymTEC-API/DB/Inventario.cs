namespace GymTEC_API.DB
{
    public class Inventario
    {
        //atributtes 
        public string tipoMaquina;
        public string marca;
        public int numSerie;
        public int costo;
        public string sucursal;
        
        //contructor, getters and setters
        public Inventario(string tipoMaquina, string marca, int numSerie, int costo, string sucursal)
        {
            this.tipoMaquina = tipoMaquina;
            this.marca = marca;
            this.numSerie = numSerie;
            this.costo = costo;
            this.sucursal = sucursal;
        }

        public string TipoMaquina
        {
            get => tipoMaquina;
            set => tipoMaquina = value;
        }

        public string Marca
        {
            get => marca;
            set => marca = value;
        }

        public int NumSerie
        {
            get => numSerie;
            set => numSerie = value;
        }

        public int Costo
        {
            get => costo;
            set => costo = value;
        }

        public string Sucursal
        {
            get => sucursal;
            set => sucursal = value;
        }
    }
}