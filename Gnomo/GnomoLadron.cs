using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnomosProyecto
{
    public class GnomoLadron : Gnomo
    {
        private string especialidad;

        public GnomoLadron(string nombre, string color, string especialidad)
            : base(nombre, color)
        {
            this.especialidad = especialidad;
        }

        public string Especialidad
        {
            get => especialidad;
            set => especialidad = value;
        }

        public bool RobarObjeto(Objeto objeto)
        {
            return objeto != null && objeto.Valor > 0;
        }
    }
}

