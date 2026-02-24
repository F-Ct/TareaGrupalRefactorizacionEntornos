using System;

namespace CIFPCarlosIII.ED.UT04.GrupoX

{
    public class Berserker : Guerrero
    {
        public int furia;
        public string arma;
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

        public void DesatarPoder()
        {
            desatado += 30;
            Console.WriteLine(nombre + " entra en estado de furia! Furia actual: " + desatado);
        }

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
