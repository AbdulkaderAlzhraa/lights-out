using lights_out.Models;

public class GameRecord
{
    public List<Move> Moves { get; set; } = new List<Move>();
    public DateTime DatePlayed { get; set; }
    public bool IsWin { get; set; }
    public int GridSize { get; set; }
    public List<bool>? InitialState { get; set; }

    public override string ToString()
    {
        return $"Date: {DatePlayed}, Moves: {Moves.Count}, Result: {(IsWin ? "Win" : "Gave Up")}, Grid: {GridSize}x{GridSize}";
    }
}
