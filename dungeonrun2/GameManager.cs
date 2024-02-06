public class GameManager : MonoBehaviour
{
    private HubConnection _hubConnection;

    void Start()
    {
        _hubConnection = new HubConnectionBuilder()
            .WithUrl("http://yourgameServerUrl/gamehub")
            .Build();

        _hubConnection.StartAsync();

        // Subscribe to events for real-time updates
        _hubConnection.On<GameState>("GameStateChanged", OnGameStateChanged);
    }

    private void OnGameStateChanged(GameState gameState)
    {
        // Handle real-time update of the entire game state
        // Update the positions of players and enemies
    }
}
