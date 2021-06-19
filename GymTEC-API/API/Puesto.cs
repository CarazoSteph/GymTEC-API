namespace GymTEC_API.DB
{
    public class Puesto
    {
        //atributtes
        public string administrador;
        public string instructor;
        public string dependienteSpa;
        public string dependienteTienda;

        //contructor
        public Puesto(string administrador, string instructor, string dependienteSpa, string dependienteTienda)
        {
            this.administrador = administrador;
            this.instructor = instructor;
            this.dependienteSpa = dependienteSpa;
            this.dependienteTienda = dependienteTienda;
        }

        //getters and setters
        public string Administrador
        {
            get => administrador;
            set => administrador = value;
        }

        public string Instructor
        {
            get => instructor;
            set => instructor = value;
        }

        public string DependienteSpa
        {
            get => dependienteSpa;
            set => dependienteSpa = value;
        }

        public string DependienteTienda
        {
            get => dependienteTienda;
            set => dependienteTienda = value;
        }
    }
}