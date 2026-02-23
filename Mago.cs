using System;

namespace CIFPCarlosIII.ED.UT04.GrupoX

{
	/// <summary>
	///	Es una clase nueva que crea un guerrero Mago que hereda todo lo que tiene un Personaje
	/// </summary>
    public class Mago : Personaje
    {
		/// <summary>
		///	Son los metodos que hacen unicos las habilidades del propio personaje
		/// </summary>
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

		/// <summary>
		///	Es un metodo que no devuelve nada simplemente hace cambios en valores que ya habian sido asignados anteriormente internamente en el juego o en este caso, en el personaje
		/// </summary>
        public void Meditar()
        {
            mana += 30;
            if (mana > 100) mana = 100;
            Console.WriteLine(nombre + " medita y recupera mana. Mana actual: " + mana);
        }
        
		/// <summary>
		///	Es un metodo que devuelve en una cadena los valores o caracteristicas del personaje y las muestra por pantalla
		/// </summary>
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
