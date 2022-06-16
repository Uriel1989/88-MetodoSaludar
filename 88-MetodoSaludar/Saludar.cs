using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _88_MetodoSaludar
{
    class Saludar
    {
        public String nombre;

        public Saludar( string nom)
        {
            Console.WriteLine("Hola, sientete bienvenido " + (this.nombre = nom));
        }

        
    }
}
