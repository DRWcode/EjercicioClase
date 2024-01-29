// See https://aka.ms/new-console-template for more information


using EjercicioClase;
// Crear superpoderes 
SuperPoder velocidad = new SuperPoder("Super Velocicad", "velocida sobrehumana", 5);
SuperPoder fuerza = new SuperPoder("Super Fuerza", "Fuerza sobrehumana", 7);
SuperPoder invisible = new SuperPoder("Invicibilidad", "Capidad de hacerse invisible", 2);

// crear Superheroes 
SuperHeroe superman = new SuperHeroe("Superman", "Clark Kent", "Metropolis", true, fuerza);
SuperHeroe flash = new SuperHeroe("Flash","Barry Allen","Ciudad Central", false, velocidad);
SuperHeroe mujerInvisible = new SuperHeroe("Mujer Invisible", "Susan Storm", "Nueva York", true, invisible);

// imprimir 
superman.Imprimir();
flash.Imprimir();
mujerInvisible.Imprimir();