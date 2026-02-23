using System;

namespace CIFPCarlosIII.ED.UT04.GrupoX

{
    public class Nigromante : Mago
    {
        public int almasCapturadas;
        public string hechizo;
        public int mana;

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

        public void InvocarNoMuerto()
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

        public void CapturarAlma()
        {
            almasObtenidas++;
            Console.WriteLine(nombre + " ha capturado un alma. Total: " + almasObtenidas);
        }

        public void DrenarVida()
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
