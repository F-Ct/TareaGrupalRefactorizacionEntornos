using System;

namespace CIFPCarlosIII.ED.UT04.GrupoX

{
    public class Mago : Personaje
    {
        private int _mana;
        public string hechizo;
		private string nombre;

		public int mana{get; set;};

        public Mago()
        {
            this.mana = 100;
            this.hechizo = "Bola de fuego";
        }

		public Mago(string nombre) : base (nombre)
		{
			this.nombre = nombre
			this.mana = 100;
            this.hechizo = "Bola de fuego";
		}

        public void LanzarHechizo()
        {
            if (mana >= 20)
            {
                Console.WriteLine(nombre + " lanza " + hechizo + "!");
                mana -= 20;
                Console.WriteLine("Mana restante: " + mana);
            }
            else
            {
                Console.WriteLine("Mana insuficiente para lanzar el hechizo.");
            }
        }

        public void Meditar()
        {
            mana += 30;
            if (mana > 100) mana = 100;
            Console.WriteLine(nombre + " medita y recupera mana. Mana actual: " + mana);
        }
        
        public string MostrarInfo()
        {
            return "=== INFORMACIÓN DEL PERSONAJE ===" +
                   "\nNombre: " + nombre +
                   "\nClase: " + this.GetType().Name +
                   "\nNivel: " + nivel +
                   "\nVida: " + vida +
                   "\nMana: " + mana +
                   "\nHechizo: " + hechizo;
        }
    }
    }
}
