
namespace Program {

    internal sealed class Board {

        internal static char XPiece = 'X';
        internal static char OPiece = 'O';

        internal readonly char[,] Positions = new char[3,3];

        private int _freeSpaces = 9;

        private readonly Dictionary<int, (int, int)> _movePositions = new()
        {
            {1, (0, 0)},
            {2, (0, 1)},
            {3, (0, 2)},
            {4, (1, 0)},
            {5, (1, 1)},
            {6, (1, 2)},
            {7, (2, 0)},
            {8, (2, 1)},
            {9, (2, 2)},
        };

        internal void SetNumbers() {
            int numberToPrint = 1;
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    Positions[i,j] = (char)('0' + numberToPrint);
                    numberToPrint++;
                }
            }
        }

        internal void Write() {
            Console.WriteLine( "┌───┬───┬───┐");
            Console.WriteLine($"│ {Positions[0,0]} │ {Positions[0,1]} │ {Positions[0,2]} │");
            Console.WriteLine( "├───┼───┼───┤");
            Console.WriteLine($"│ {Positions[1,0]} │ {Positions[1,1]} │ {Positions[1,2]} │");
            Console.WriteLine( "├───┼───┼───┤");
            Console.WriteLine($"│ {Positions[2,0]} │ {Positions[2,1]} │ {Positions[2,2]} │");
            Console.WriteLine( "└───┴───┴───┘");
        }

        internal void Reset() {
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    Positions[i,j] = ' ';
                }
            }
            Console.Clear();
        }

        internal void SetMove(int move, char piece) {
            if (_movePositions.TryGetValue(move, out var position)) {
                if (Positions[position.Item1, position.Item2] == ' ') {
                    Positions[position.Item1, position.Item2] = piece;
                    _freeSpaces--;
                }
            }
            CheckPositions();
        }

        internal bool IsPositionUsed(int move) {
            _movePositions.TryGetValue(move, out var position);

            if (Positions[position.Item1, position.Item2] != ' ') {
                return true;
            }

            return false;
        }

        internal void CheckPositions() {
            for (int i = 0; i < 3; i++) {
                if (Positions[i,0] == Positions[i,1] && Positions[i,0] == Positions[i,2] && Positions[i,0] != ' ') {
                    GameCycle.GameState = GameState.Ended;
                }
            }

            for (int i = 0; i < 3; i++) {
                if (Positions[0,i] == Positions[1,i] && Positions[0,i] == Positions[2,i] && Positions[0,i] != ' ') {
                    GameCycle.GameState = GameState.Ended;
                }
            }

            for (int i = 0; i < 3; i++) {
                if (Positions[0,0] == Positions[1,1] && Positions[0,0] == Positions[2,2] && Positions[0,0] != ' ') {
                    GameCycle.GameState = GameState.Ended;
                }
                else if (Positions[0,2] == Positions[1,1] && Positions[0,2] == Positions[2,0] && Positions[0,2] != ' ') {
                    GameCycle.GameState = GameState.Ended;
                }
            }

            if (_freeSpaces <= 0) {
                GameCycle.GameState = GameState.Ended;
            }
        }

    }
}