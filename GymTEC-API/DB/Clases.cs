namespace GymTEC_API.DB
{
    public class Clases
    {
        //attributes
        public string tipo;
        public string instructor;
        public bool individual;
        public int capacidad;
        public string fecha;
        public string horaInicio;
        public string horaFin;

        //constructor
        public Clases(string tipo, string instructor, bool individual, int capacidad, string fecha, string horaInicio, string horaFin)
        {
            this.tipo = tipo;
            this.instructor = instructor;
            this.individual = individual;
            this.capacidad = capacidad;
            this.fecha = fecha;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
        }
        //getters and setters
        public string Tipo
        {
            get => tipo;
            set => tipo = value;
        }

        public string Instructor
        {
            get => instructor;
            set => instructor = value;
        }

        public bool Individual
        {
            get => individual;
            set => individual = value;
        }

        public int Capacidad
        {
            get => capacidad;
            set => capacidad = value;
        }

        public string Fecha
        {
            get => fecha;
            set => fecha = value;
        }

        public string HoraInicio
        {
            get => horaInicio;
            set => horaInicio = value;
        }

        public string HoraFin
        {
            get => horaFin;
            set => horaFin = value;
        }
    }
}