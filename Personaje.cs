using System;

namespace CIFPCarlosIII.ED.UT04.GrupoX

{
    /// <summary>
    ///  Clase Personaje en el que se recoje cada estadistica y accion que cualquier personaje puede hacer.
    /// </summary>
    public class Personaje
    {
        /// <summary>
        /// Atributos publicos. Estos sirven para despues nombrarlos en Metodos , propiedades, constructores....
        /// </summary>
        public string nombre;
        public int vida;
        public int nivel;
        
        /// <summary>
        /// Constructor, el cual le da unas estadisticas a cualquier personaje nuevo que se cree
        /// </summary>
        public Personaje()
        {
            this.vida = 100;
            this.nivel = 1;
        }
        /// <summary>
        /// Metodo atacar, que hace que el personaje realice un ataque
        /// </summary>
        public void Atacar()
        {
            Console.WriteLine(nombre + " realiza un ataque básico!");
        }
        
        /// <summary>
        /// Metodo que realiza la accion de recibir daño.
        /// </summary>
        /// <param name="danio"></param>
        public void RecibirDanio(int danio)
        {
            vida -= danio;
            Console.WriteLine(nombre + " recibe " + danio + " de daño. Vida restante: " + vida);
        }
        
        /// <summary>
        ///  Metodo que realiza la accion de subir de nivel. Cada vez que se suba, sube un nivel y sube 20 de vida
        /// </summary>
        public void SubirNivel()
        {
            nivel++;
            vida += 20;
            Console.WriteLine(nombre + " ha subido al nivel " + nivel + "!");
        }
    }
}
