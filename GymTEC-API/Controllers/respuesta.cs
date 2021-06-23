namespace GymTEC_API.Controllers
{
    public class respuesta
    {
        public string status;
        public string respuestaS;

        //Contructor los datos de respuesta no son siempre necesarios
        public respuesta(string status)
        {
            this.status = status;
        }
        //Getters y setters
        public string Status
        {
            get => status;
            set => status = value;
        }

        public string RespuestaS
        {
            get => respuestaS;
            set => respuestaS = value;
        }
    }
    
    //Plantilla de datos ingresados por el usuario desde la web app
    public class LoginEntrada
    {
        public string correo;
        public string contrasena;

        public LoginEntrada(string correo, string contrasena)
        {
            this.correo = correo;
            this.contrasena = contrasena;
        }

        public string Correo
        {
            get => correo;
            set => correo = value;
        }

        public string Contrasena
        {
            get => contrasena;
            set => contrasena = value;
        }
    }
    public class BusquedaEntrada
    {
        public string busquedaEnt;

        public BusquedaEntrada(string busquedaEnt)
        {
            this.busquedaEnt = busquedaEnt;
                
        }

        public string BusquedaEnt
        {
            get => busquedaEnt;
            set => busquedaEnt = value;
        }
    }
    
    public class PlanillaMensual
    {
        public string nombre;
        public int numeroCedula;
        public int monto;

        public PlanillaMensual(string nombre, int numeroCedula, int monto)
        {
            this.nombre = nombre;
            this.numeroCedula = numeroCedula;
            this.monto = monto;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public int NumeroCedula
        {
            get => numeroCedula;
            set => numeroCedula = value;
        }

        public int Monto
        {
            get => monto;
            set => monto = value;
        }
    }

    public class planillaHoras
    {
        public string nombre;
        public int numeroCedula;
        public int horas;
        public int monto;

        public planillaHoras(string nombre, int numeroCedula, int horas, int monto)
        {
            this.nombre = nombre;
            this.numeroCedula = numeroCedula;
            this.horas = horas;
            this.monto = monto;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public int NumeroCedula
        {
            get => numeroCedula;
            set => numeroCedula = value;
        }

        public int Horas
        {
            get => horas;
            set => horas = value;
        }

        public int Monto
        {
            get => monto;
            set => monto = value;
        }
    }

    public class planillaClases
    {
        public string nombre;
        public int numeroCedula;
        public int clases;
        public int monto;

        public planillaClases(string nombre, int numeroCedula, int clases, int monto)
        {
            this.nombre = nombre;
            this.numeroCedula = numeroCedula;
            this.clases = clases;
            this.monto = monto;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public int NumeroCedula
        {
            get => numeroCedula;
            set => numeroCedula = value;
        }

        public int Clases
        {
            get => clases;
            set => clases = value;
        }

        public int Monto
        {
            get => monto;
            set => monto = value;
        }
    }

}