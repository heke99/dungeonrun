using System.Numerics;

[Serializable]
public class GameState
{
    public List<Player> Players { get; set; }
    public List<Enemy> Enemies { get; set; }
    // Add other game state properties
}
