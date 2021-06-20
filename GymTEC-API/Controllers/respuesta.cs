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

        public string Correo => correo;

        public string Contrasena => contrasena;
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

}