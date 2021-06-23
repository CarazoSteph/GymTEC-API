namespace GymTEC_API.DB
{
    public class Empleado
    {
        public int numCedula;
        public string nombre;
        public string direccion;
        public string puesto;
        public string sucursal;
        public int tipoPlanilla;
        public int salario;
        public string correoElectronico;
        private string password;
        public int horasTrabajadas;
        public int clasesRealizadas;

        //constructor
        public Empleado(int numCedula, string nombre, string direccion, string puesto, string sucursal, int tipoPlanilla, int salario, string correoElectronico,
                        string password, int horasTrabajadas, int clasesRealizadas)
        {
            this.numCedula = numCedula;
            this.nombre = nombre;
            this.direccion = direccion;
            this.puesto = puesto;
            this.sucursal = sucursal;
            this.tipoPlanilla = tipoPlanilla;
            this.salario = salario;
            this.correoElectronico = correoElectronico;
            this.password = password;
            this.horasTrabajadas = horasTrabajadas;
            this.clasesRealizadas = clasesRealizadas;
        }

        //getters and setters
        public int HorasTrabajadas
        {
            get => horasTrabajadas;
            set => horasTrabajadas = value;
        }

        public int ClasesRealizadas
        {
            get => clasesRealizadas;
            set => clasesRealizadas = value;
        }

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

        public string Direccion
        {
            get => direccion;
            set => direccion = value;
        }

        public string Puesto
        {
            get => puesto;
            set => puesto = value;
        }

        public string Sucursal
        {
            get => sucursal;
            set => sucursal = value;
        }

        public int TipoPlanilla
        {
            get => tipoPlanilla;
            set => tipoPlanilla = value;
        }

        public int Salario
        {
            get => salario;
            set => salario = value;
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