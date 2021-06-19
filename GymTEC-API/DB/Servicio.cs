namespace GymTEC_API.DB
{
    public class Servicio
    {
        //atributtes
        public string indoorCycling;
        public string pilates;
        public string yoga;
        public string natacion;

        //constructor
        public Servicio(string indoorCycling, string pilates, string yoga, string natacion)
        {
            this.indoorCycling = indoorCycling;
            this.pilates = pilates;
            this.yoga = yoga;
            this.natacion = natacion;
        }

        //getters and setters
        public string IndoorCycling
        {
            get => indoorCycling;
            set => indoorCycling = value;
        }

        public string Pilates
        {
            get => pilates;
            set => pilates = value;
        }

        public string Yoga
        {
            get => yoga;
            set => yoga = value;
        }

        public string Natacion
        {
            get => natacion;
            set => natacion = value;
        }
    }
}