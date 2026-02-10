using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnomosProyecto
{
    public class Objeto
    {
        private string tipo;
        private double valor;

        public Objeto(string tipo, double valor)
        {
            this.tipo = tipo;
            this.valor = valor;
        }

        public string Tipo
        {
            get => tipo;
            set => tipo = value;
        }

        public double Valor
        {
            get => valor;
            set => valor = value;
        }
    }
}

