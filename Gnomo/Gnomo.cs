
namespace GnomosProyecto
{
    public class Gnomo
    {
        protected string nombre;
        protected string color;

        public Gnomo(string nombre, string color)
        {
            this.nombre = nombre;
            this.color = color;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Color
        {
            get => color;
            set => color = value;
        }
    }
}






