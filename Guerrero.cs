using System;

namespace CIFPCarlosIII.ED.UT04.GrupoX

{
    /// <summary>
 /// Clase Guerrero que hereda de Personaje.
 /// </summary>
    public class Guerrero : Personaje
    {
        /// <summary>
        /// Atributos publicos que tiene cada guerrero
        /// </summary>
        public int fuerza;
        public string arma;
		private string nombre;
        /// <summary>
        /// Constructor del gerrero, el cual asigna sus estadisticas y arma principal
        /// </summary>
        public Guerrero()
        {
            this.fuerza = 15;
            this.arma = "Espada";
        }

		public Guerrero(string nombre) : base(nombre)
		{
			this.nombre = nombre;
			this.fuerza = 15;
            this.arma = "Espada";
        }
        /// <summary>
        /// Metodo el cual realiza un Ataque poderoso.
        /// Este metodo hace uso de arma y la fuerza
        /// </summary>
        public void AtaquePoderoso()
        {
            Console.WriteLine(nombre + " usa su " + arma + " para realizar un ataque poderoso!");
            Console.WriteLine("Daño infligido: " + (fuerza * 2));
        }
    /// <summary>
    /// Metodo que realiza la accion de DefenderseConEscudo
    /// Este hace uso de nombre.
    /// </summary>
        public void DefenderseConEscudo()
        {
            Console.WriteLine(nombre + " se defiende con su escudo, reduciendo el daño recibido.");
        }
        public string MostrarInfo()
        {
            return "=== INFORMACIÓN DEL PERSONAJE ===" +
                   "\nNombre: " + nombre +
                   "\nClase: " + this.GetType().Name +
                   "\nNivel: " + nivel +
                   "\nVida: " + vida +
                   "\nFuerza: " + fuerza +
                   "\nArma: " + arma;
        }
    }
}

