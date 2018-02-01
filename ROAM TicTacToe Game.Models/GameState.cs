namespace ROAMTicTacToe.Models
{
    public enum GameState
    {
        WaitingForSecondPlayer = 0,
        TurnX = 1,
        TurnO = 2,
        GameWonByX = 2,
        GameWonByO = 4,
        GameDraw =6,
    }
}
