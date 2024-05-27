
namespace Program {

    internal class Present {

        public char Presentation() {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("¡Bienvenido a TicTacToe de consola!");
            Console.WriteLine("¡Presione cualquier tecla para continuar!");
            Console.WriteLine("-----------------------------------------");
            
            Console.WriteLine();

            Console.WriteLine("Elija que jugador quiere ser (X/O)");

            return Console.ReadKey().KeyChar;
        }
        
    }
}