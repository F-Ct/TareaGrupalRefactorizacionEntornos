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
        public string arma;		
		/// <summary>
		///	Es un contructor (metodo) que le aplica y crea las caracteristicas del personaje y les da un valor en el juego
		/// </summary>
        public int fuerza;

        public Poder(int potencia)
        {
            fuerza = potencia;
            potencia = 20;
        }

        public Mejora(int desatado)
        {
            furia = desatado;
            desatado = 0;
        }

        public Equipamiento(string equipo)
        {
            arma = equipo;
            equipo = "Hacha de batalla";
        }
		/// <summary>
		///	Es un metodo que no devuelve nada simplemente hace cambios en valores que ya habian sido asignados anteriormente internamente en el juego o en este caso, en el personaje
		/// </summary>
        public void DesatarPoder()
        {
            desatado += 30;
            Console.WriteLine(nombre + " entra en estado de furia! Furia actual: " + desatado);
        }
		
		/// <summary>
		///	Es un metodo que no devuelve nada simplemente hace cambios en valores que ya habian sido asignados anteriormente internamente en el juego o en este caso, en el personaje
		/// </summary>
        public void AtaqueDesatado()
        {
            if (desatado >= 50)
            {
                Console.WriteLine(nombre + " desata un ataque furioso devastador!");
                Console.WriteLine("Daño masivo: " + (potencia * 3 + desatado));
                desatado = 0;
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
                   "\nFuerza: " + potencia +
                   "\nArma: " + equipo +
                   "\nFuria: " + desatado;
        }
    }
}
