namespace GymTEC_API.DB
{
    public class Producto
    {
        //attributes
        public string nombre;
        public int codigoBarras;
        public string descripcion;
        public int costo;

        //constructor
        public Producto(string nombre, int codigoBarras, string descripcion, int costo)
        {
            this.nombre = nombre;
            this.codigoBarras = codigoBarras;
            this.descripcion = descripcion;
            this.costo = costo;
        }

        //getters and setters
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public int CodigoBarras
        {
            get => codigoBarras;
            set => codigoBarras = value;
        }

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }

        public int Costo
        {
            get => costo;
            set => costo = value;
        }
    }
}