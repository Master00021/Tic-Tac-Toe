
namespace Program {

    internal class TicTacToe {

        public static void Main(string[] args) {
            var present = new Present();
            char player = present.Presentation();
            Console.Clear();

            Console.WriteLine( "┌───┬───┬───┐");
            Console.WriteLine($"│ 1 │ 2 │ 3 │");
            Console.WriteLine( "├───┼───┼───┤");
            Console.WriteLine($"│ 4 │ 5 │ 6 │");
            Console.WriteLine( "├───┼───┼───┤");
            Console.WriteLine($"│ 7 │ 8 │ 9 │");
            Console.WriteLine( "└───┴───┴───┘");

            var Turn = new Turn();
            int movement = Turn.PlayerMovement();
            Console.Clear();

            Turn.PlayerTurn(player, movement);

            Console.ReadKey();
        }

    }
}