
namespace Program {

    internal class Turn {

        private int[] _movePositions = { 0, 1, 2, 3, 4, 5, 6, 7, 8};

        internal void Board() {
            
        }

        internal void PlayerTurn(char player, int position) {
            bool playerMoved = false;
            bool lineWrited = false;
            
            position--;

            Console.WriteLine( "┌───┬───┬───┐");

            for (int i = 0; i < _movePositions.Length; i++) {
                bool lineStarted = i == 2 || i == 5 || i == 8;
                
                if (_movePositions[i] == position) {
                    if (position == 0 || position == 3 || position == 6) {
                        Console.WriteLine($"│ {player} │   │   │");
                    }
                    else if (position == 1 || position == 4 || position == 7) {
                        Console.WriteLine($"│   │ {player} │   │");
                    }
                    else if (position == 2 || position == 5 || position == 8) {
                        Console.WriteLine($"│   │   │ {player} │");
                    }
                    else {
                        Console.WriteLine("│   │   │   │");
                    }

                    playerMoved = true;
                }
                
                if (!playerMoved && lineStarted) {
                    Console.WriteLine("│   │   │   │");
                    lineWrited = true;
                }

                if ((playerMoved || lineWrited) && i == 2 || i == 5) {
                    Console.WriteLine("├───┼───┼───┤");
                    playerMoved = false;
                    lineWrited = false;
                }
            }

            Console.WriteLine( "└───┴───┴───┘");
        }

        internal int PlayerMovement() {
            Console.WriteLine("Elija una casilla según su número");

            int key = Convert.ToInt32(Console.ReadLine());
            return key;
        }

    }
}