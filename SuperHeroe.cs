using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    internal class SuperHeroe
    {
        public String? Nombre {  get; set; }
        public String? IdentidadSecreta { get; set; }
        public String? Ciudad {  get; set; }
        public bool PuedeVolar { get; set; }
        public SuperPoder? SuperPoder { get; set; }

        // constructor
        public SuperHeroe(string nombre, string identidadSecreta, string ciudad, bool puedeVolar, SuperPoder superPoder)
        {
            Nombre = nombre;
            IdentidadSecreta = identidadSecreta;
            Ciudad = ciudad;
            PuedeVolar = puedeVolar;
            SuperPoder = superPoder;
        }

        // metodo imprimir 
        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Identidad Secreta: {IdentidadSecreta}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Puede Volar: {PuedeVolar}");
            SuperPoder.Imprimir(); 
        }

    }
}
