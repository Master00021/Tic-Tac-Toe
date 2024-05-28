
namespace Program {

    internal sealed class Player {

        internal static char Piece;

        internal void SelectPiece() {
            bool pieceSelected = false;

            while (!pieceSelected) {
                Console.WriteLine("Elija su pieza: X/O");
                char piece = Console.ReadKey().KeyChar;

                if (piece == 'x' || piece == 'X') {
                    Piece = Board.XPiece;
                    pieceSelected = true;
                }
                else if (piece == 'o' || piece == 'O') {
                    Piece = Board.OPiece;
                    pieceSelected = true;
                }
                else {
                    Console.Clear();
                    Console.WriteLine("Carácter no soportado, presione para reiniciar.");
                    Console.ReadKey();
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        internal int Move(Board board) {
            int move = 0;

            while (GameCycle.GameState == GameState.Playing) {
                Console.Clear();
                board.Write();
                Console.WriteLine("Ingrese su movimiento (1-9).");

                ConsoleKeyInfo userInput = Console.ReadKey();

                if (int.TryParse(userInput.KeyChar.ToString(), out move) && move >= 1 && move <= 9) {
                    if (board.IsPositionUsed(move))  {
                        Console.Clear();
                        board.Write();
                        Console.WriteLine("La casilla ya está ocupada, haga otro movimiento.");
                        Console.ReadKey();
                    }
                    else {
                        Console.ReadKey();
                        break;
                    }
                }
                else {
                    Console.Clear();
                    board.Write();
                    Console.WriteLine("Entrada inválida, por favor ingrese un número del 1 al 9.");
                    Console.ReadKey();
                }
            }

            Console.Clear();
            return move;
        }

    }
}