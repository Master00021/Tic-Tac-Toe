
namespace Program {

    internal enum GameState {
        Playing,
        Ended,
        CloseGame
    }

    internal class GameCycle {

        internal static GameState GameState;

        internal void RestartGame() {
            var present = new Present();
            var board = new Board();
            var player = new Player();
            var bot = new Bot();

            Console.Clear();

            present.Presentation();

            board.SetNumbers();
            board.Write();

            GameState = GameState.Playing;

            player.SelectPiece();
            bot.SetPiece();
        }

    }
}