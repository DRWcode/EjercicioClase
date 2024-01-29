using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    internal class SuperPoder
    {
        public String? Nombre { get; set; }
        public String? Descripcion { get; set; }
        public int Nivel { get; set; }

        // constructor
        public SuperPoder(string nombre, String descripcion, int nivel)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Nivel = nivel;

        }
        // metodo imprimir
        public void Imprimir()
        {
            Console.WriteLine($"Super Poder: ");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Descripcion: {Descripcion}");
            Console.WriteLine($"Nivel: {Nivel}");
            Console.WriteLine();
        }

    }


}
