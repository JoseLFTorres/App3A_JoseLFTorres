using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones.Cafeteria
{
    internal class Bebida
    {
        //atributos 
        protected string Nombre;
        protected string Tamaño;
        protected float Precio;

        //propiedades
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public string tamaño {  
            get { return Tamaño; }
            set { Tamaño = value; }
        }

        private float precio
        {
            get { return Precio; }
            set {  if (value > 0) 
                    Precio = value;
                }
        }

        //constructor parametrizado
        public Bebida(string _nombre, string _tamaño, float _precio)
        {
            Nombre = _nombre;
            Tamaño = _tamaño;
            Precio= _precio;
        }

        // contructor vacio
        public Bebida()
        {
            Nombre = "";
            Tamaño = "";
            Precio = 0.0F;
        }

        //metodos 
        public virtual string Preparar()
        {
            return "Preparando un : "+ Nombre + " de tamaño : "+Tamaño;
        }

        public void Descuento(float descuento)
        {
            Precio = Precio * (1 - (descuento / 100));
        }

    }
}
