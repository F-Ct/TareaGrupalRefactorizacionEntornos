using System;

namespace CIFPCarlosIII.ED.UT04.GrupoX

{
	/// Hereda de Mago.
    public class Nigromante : Mago
    {
		/// Cantidad de almas capturadas por el nigromante.
        public int almasCapturadas;
		///Hechizo que conoce.
        public string hechizo;
		/// Total del mana que posee.
        public int mana;

		///Constructor del ManaTotal, las Almas y su Habilidad.
        public ManaTotal(int magia)
        {
         mana = magia;
         magia = 120;
        }
        public Almas (int almasObtenidas)
        {
            almasCapturadas = almasObtenidas;
            almasObtenidas = 0;
        }

        public Habilidad (string conjuro)
        {
            hechizo = conjuro;
            conjuro = "Drenado de vida";
        }

		/// Invoca un no-muerto utilizando las almas capturadas.
        public void RevivirAlmas()
        {
            if (magia >= 40 && almasObtenidas >= 1)
            {
                Console.WriteLine(nombre + " invoca un no-muerto usando un alma capturada!");
                magia -= 40;
                almasObtenidas--;
                Console.WriteLine("Almas restantes: " + almasObtenidas);
            }
            else
            {
                Console.WriteLine("No hay suficiente magia o almas para invocar.");
            }
        }
		///  Captura un alma para usarla en rituales o invocaciones.
        public void ConservarAlma()
        {
            almasObtenidas++;
            Console.WriteLine(nombre + " ha capturado un alma. Total: " + almasObtenidas);
        }
		
		/// Drena la vida de un enemigo para recuperar energía.
        public void Sanguijuela()
        {
            if (magia >= 25)
            {
                Console.WriteLine(nombre + " drena la vida de su enemigo!");
                magia -= 25;
                vida += 15;
                Console.WriteLine("Vida recuperada. Vida actual: " + vida);
            }
        }
    }
}
