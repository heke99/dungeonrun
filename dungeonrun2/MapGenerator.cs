using System;

public class MapGenerator : IMapGenerator
{
    public List<Enemy> GenerateEnemies(int count)
    {
        // Implement logic to generate enemies on the map
        // For simplicity, randomly generate enemies in different positions
        var enemies = new List<Enemy>();
        var random = new Random();

        for (int i = 0; i < count; i++)
        {
            enemies.Add(new Enemy
            {
                X = random.Next(-10, 10),
                Y = random.Next(-10, 10)
            });
        }

        return enemies;
    }
}
