using System;

namespace CIFPCarlosIII.ED.UT04.GrupoX

{
	/// <summary>
	///	Es una clase hija de Guerrero que crea un nuevo personaje con habilidades y caracterisiticas propias ademas de las de el Guerrero (el padre)
	/// </summary>
    public class Berserker : Guerrero
    {
		/// <summary>
		///	Es un atributo publico unico de este personaje
		/// </summary>
        public int furia;
		
		/// <summary>
		///	Es un contructor (metodo) que le aplica y crea las caracteristicas del personaje y les da un valor en el juego
		/// </summary>
        public Berserker()
        {
            this.furia = 0;
            this.arma = "Hacha de batalla";
            this.fuerza = 20;
        }
		/// <summary>
		///	Es un metodo que no devuelve nada simplemente hace cambios en valores que ya habian sido asignados anteriormente internamente en el juego o en este caso, en el personaje
		/// </summary>
        public void EntrarEnFuria()
        {
            furia += 30;
            Console.WriteLine(nombre + " entra en estado de furia! Furia actual: " + furia);
        }
		
		/// <summary>
		///	Es un metodo que no devuelve nada simplemente hace cambios en valores que ya habian sido asignados anteriormente internamente en el juego o en este caso, en el personaje
		/// </summary>
        public void AtaqueFurioso()
        {
            if (furia >= 50)
            {
                Console.WriteLine(nombre + " desata un ataque furioso devastador!");
                Console.WriteLine("Daño masivo: " + (fuerza * 3 + furia));
                furia = 0;
            }
            else
            {
                Console.WriteLine("Furia insuficiente para realizar ataque furioso.");
            }
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
                   "\nFuerza: " + fuerza +
                   "\nArma: " + arma +
                   "\nFuria: " + furia;
        }
    }
}
