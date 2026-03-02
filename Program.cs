using System;

namespace CIFPCarlosIII.ED.UT04.GrupoX

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BIENVENIDO AL REINO DE LOS HÉROES ===\n");
           
            /// El personaje base dentro del mundo RPG.
            /// Contiene atributos y comportamientos comunes a todos los personajes.
            Personaje personaje = new Personaje();
            
            /// Nombre del personaje. Se utiliza para identificarlo en el juego.
            personaje.nombre = "Héroe Genérico";
            
            /// Constructor por defecto que inicializa un nuevo personaje genérico.
            Console.WriteLine("Se ha creado un personaje: " + personaje.nombre);
            
            /// Ejecuta un ataque básico del personaje.
            personaje.Atacar();
            
            /// Subida del nivel del personaje, sufre un aumento en sus estadísticas.
            personaje.SubirNivel();
            
            /// Un guerrero especializado en combate físico y con habilidades defensivas.
            Console.WriteLine("\n--- Guerrero ---");
            
            /// Constructor por defecto del guerrero.
            Guerrero guerrero = new Guerrero();
            guerrero.nombre = "Guerrero Valiente";
            guerrero.Atacar();
            
            /// Realiza un ataque poderoso que inflige más daño que un ataque normal.
            guerrero.AtaquePoderoso();
            
            /// El guerrero utiliza su escudo para reducir el daño recibido.
            guerrero.DefenderseConEscudo();
            
            ///Un berserker es un guerrero que entra en estados de furia para aumentar su poder.
            Console.WriteLine("\n--- Berserker ---");
            Berserker bers = new Berserker();
            bers.nombre = "Guts";
           
            /// Entrar en estado de furia y usar sus ventajas.
            bers.DesatarPoder();
            bers.DesatarPoder();
            bers.AtaqueDesatado();
            Console.WriteLine("\n" + bers.MostrarInfo());

            /// Un mago especializado en el uso de hechizos y energía mágica.
            Console.WriteLine("\n--- Mago ---");
            Mago magi = new Mago();
            magi.nombre = "Merlín";
            
            ///Ejecutar los hechizos.
            magi.LanzarHechizo();
            magi.LanzarHechizo();
            magi.Meditar();
            magi.LanzarHechizo();

            /// Un nigromante es un maestro de las artes oscuras y es capaz de manipular almas.
            Console.WriteLine("\n--- Nigromante ---");
            Nigromante nigro = new Nigromante();
            nigro.nombre = "El que no puede ser nombrado";
            
            ///Manipulación de las almas.
            nigro.ConservarAlma();
            nigro.ConservarAlma();
            nigro.RevivirAlmas();
            nigro.Sanguijuela();

            Console.WriteLine("\n=== FIN DE LA DEMOSTRACIÓN ===");
            Console.ReadLine();
        }
    }
}
