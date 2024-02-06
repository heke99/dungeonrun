using System.Diagnostics;
using System.Numerics;

public class PlayerController : MonoBehaviour
{
    private HubConnection _hubConnection;

    void Start()
    {
        _hubConnection = new HubConnectionBuilder()
            .WithUrl("http://yourgameServerUrl/gamehub")
            .Build();

        _hubConnection.StartAsync();

        // Subscribe to events for real-time updates
        _hubConnection.On<Player>("PlayerMoved", OnPlayerMoved);
        _hubConnection.On<string>("InvalidMove", OnInvalidMove);
    }

    void Update()
    {
        // Player movement logic
        // ...

        // Move the player locally
        // ...

        // Send the new position to the server
        _hubConnection.SendAsync("MovePlayer", newPositionX, newPositionY);
    }

    private void OnPlayerMoved(Player player)
    {
        // Handle real-time update of other players' positions
        // Update the position of the player with player.Username == player.Username
    }

    private void OnInvalidMove(string message)
    {
        // Handle invalid move
        Debug.LogError($"Invalid move: {message}");
    }
}
