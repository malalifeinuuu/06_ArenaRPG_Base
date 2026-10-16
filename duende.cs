using System;

namespace ArenaRPG
{
    public class Duende : SerMitologico, IRecompensable
    {
        // Constructor: Asigna Nombre y Vida iniciales
        public Duende()
        {
            Nombre = "Duende Ladrón";
            Vida = 50;
        }

        // Sobrescribimos el método abstracto Atacar de la clase base SerMitologico
        public override void Atacar()
        {
            Console.WriteLine("El duende lanza una piedra!");
        }

        // Implementamos el método de la interfaz IRecompensable
        public void SoltarBotin()
        {
            Console.WriteLine("El duende soltó 15 monedas de oro.");
        }
    }
}