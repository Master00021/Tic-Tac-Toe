
namespace Program {

    internal class Program {

        public static void Main(string[] args) {
            do {
                var gameCycle = new GameCycle();
                var board = new Board();
                var player = new Player();
                var bot = new Bot();

                gameCycle.RestartGame();

                board.Reset();

                while (GameCycle.GameState == GameState.Playing) {
                    int playerMove = player.Move(board);
                    board.SetMove(playerMove, Player.Piece);
                    board.Write();

                    int iaMove = bot.Move(board);
                    board.SetMove(iaMove, Bot.Piece);
                    board.Write();
                }

                Console.Clear();
                Console.WriteLine("Partida terminada.");
                Console.WriteLine("¿Quiere seguir jugando? (s/n)");

                char election = Console.ReadKey().KeyChar;

                if (election != 's' && election != 'S') {
                    GameCycle.GameState = GameState.CloseGame;
                }

            } while (GameCycle.GameState != GameState.CloseGame);
        }

    }
}