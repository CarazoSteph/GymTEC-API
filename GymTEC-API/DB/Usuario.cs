namespace GymTEC_API.DB
{
    public class Usuario
    {
        //attributes
        public int numCedula;
        public string nombre;
        public int edad;
        public string fechaNacimiento;
        public string peso;
        public string IMC;
        public string direccion;
        public string correoElectronico;
        private string password;

        //constructor
        public Usuario(int numCedula, string nombre, int edad, string fechaNacimiento, string peso, string imc, string direccion, string correoElectronico, string password)
        {
            this.numCedula = numCedula;
            this.nombre = nombre;
            this.edad = edad;
            this.fechaNacimiento = fechaNacimiento;
            this.peso = peso;
            IMC = imc;
            this.direccion = direccion;
            this.correoElectronico = correoElectronico;
            this.password = password;
        }

        //getters and setters
        public int NumCedula
        {
            get => numCedula;
            set => numCedula = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public int Edad
        {
            get => edad;
            set => edad = value;
        }

        public string FechaNacimiento
        {
            get => fechaNacimiento;
            set => fechaNacimiento = value;
        }

        public string Peso
        {
            get => peso;
            set => peso = value;
        }

        public string Imc
        {
            get => IMC;
            set => IMC = value;
        }

        public string Direccion
        {
            get => direccion;
            set => direccion = value;
        }

        public string CorreoElectronico
        {
            get => correoElectronico;
            set => correoElectronico = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }
    }
}