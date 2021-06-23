using System.Collections.Generic;

namespace GymTEC_API.DB
{
    public class Clases
    {
        //attributes
        public int idClase;
        public string tipo;
        public string instructor;
        public int individual;
        public int capacidad;
        public string fecha;
        public string horaInicio;
        public string horaFin;
        public IList<Usuario> ListaUsuarios;

        //constructor
        public Clases(int idClase, string tipo, string instructor, int individual, int capacidad, string fecha, string horaInicio, string horaFin)
        {
            this.idClase = idClase;
            this.tipo = tipo;
            this.instructor = instructor;
            this.individual = individual;
            this.capacidad = capacidad;
            this.fecha = fecha;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            ListaUsuarios = new List<Usuario>();
;        }
        //getters and setters

        public IList<Usuario> ListaUsuarios1
        {
            get => ListaUsuarios;
            set => ListaUsuarios = value;
        }

        public int IdClase
        {
            get => idClase;
            set => idClase = value;
        }
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

        public int Individual
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