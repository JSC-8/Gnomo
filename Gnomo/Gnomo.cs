
namespace GnomosProyecto
{
    public class Gnomo
    {
        protected string nombre;
        protected string color;
        protected int vida;

        public Gnomo(string nombre, string color, int vida)
        {
            this.nombre = nombre;
            this.color = color;
            this.vida = vida;
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






