using Calificaciones.Cafeteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3A.Cafeteria
{
    internal class BebidaSuero : Bebida
    {
        private int Electrolitos;
        private bool ConAzucar;

        public int electrolitos
        {
            get { return Electrolitos; }
            set { Electrolitos = value; }
        }

        public bool conAzucar
        {
            get { return ConAzucar; }
            set { ConAzucar = value; }
        }

        public BebidaSuero(string _nombre, string _tamaño, float _precio, int _electrolitos, bool _conAzucar)
            : base(_nombre, _tamaño, _precio)
        {
            Electrolitos = _electrolitos;
            ConAzucar = _conAzucar;
        }

        public override string Preparar()
        {
            string azucar;

            if (ConAzucar == true)
            {
                azucar = "Con azúcar";
            }
            else
            {
                azucar = "Sin azúcar";
            }

            return "Preparando un : " + Nombre + " Suero de tamaño : " + Tamaño +
                   "\nElectrolitos : " + Electrolitos +
                   "\n" + azucar;
        }

        public string Mensaje()
        {
            return Nombre + " Suero";
        }
    }
}
