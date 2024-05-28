
namespace Program {

    internal class Bot {

        internal static char Piece;

        internal void SetPiece() {
            if (Player.Piece == Board.XPiece) {
                Piece = Board.OPiece;
            }
            else {
                Piece = Board.XPiece;
            }
        }

        internal int Move(Board board) {
            var random = new Random();
            int move;
            do {
                move = random.Next(1, 9);
            } while (board.IsPositionUsed(move) && GameCycle.GameState == GameState.Playing);

            Console.Clear();
            return move;
        }

    }
}