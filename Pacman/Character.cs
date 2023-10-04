
/// <summary>
/// 2D Character for console game.
/// </summary>
public class Character
{
    public struct Position
    {
        /// <summary>
        /// Horizontal position of the character.
        /// </summary>
        public int x { get; set; }

        /// <summary>
        /// Vertical position of the character.
        /// </summary>
        public int y { get; set; }

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Position()
        {
            this.x = 0; 
            this.y = 0;
        }
    }

    public Position position = new Position();
    /// <summary>
    /// Indicates whether the character is dead or not.
    /// </summary>
    public bool isDead { get; set; }

    public int? Health { get; set; }

    /// <summary>
    /// Direction in which the character is facing.
    /// </summary>
    public dir direction { get; set; }
    public dir queuedDir { get; set; }

    /// <summary>
    /// Enumeration defining possible directions for the character.
    /// </summary>
    public enum dir
    {
        Up, Down, Left, Right, NoDir
    }

    /// <summary>
    /// Handles user input to change the character's direction.
    /// </summary>
    public void HandleInput()
    {
        ConsoleKeyInfo input = Console.ReadKey(intercept: true);

        Dictionary<ConsoleKey, dir> keyToDirection = new Dictionary<ConsoleKey, dir>
        {
            { ConsoleKey.W, dir.Up },
            { ConsoleKey.A, dir.Left },
            { ConsoleKey.S, dir.Down },
            { ConsoleKey.D, dir.Right },
            { ConsoleKey.UpArrow, dir.Up },
            { ConsoleKey.LeftArrow, dir.Left },
            { ConsoleKey.DownArrow, dir.Down },
            { ConsoleKey.RightArrow, dir.Right }
        };

        if (keyToDirection.TryGetValue(input.Key, out dir Direction))
        {
            this.queuedDir = Direction;
        }
    }

    /// <summary>
    /// Moves the character in the direction he's facing.
    /// </summary>
    /// <param name="moveDirection">The direction in which the character should move.</param>
    public void Move()
    {
        Position newPosition = position;
        switch (direction)
        {
            case dir.Left:
                newPosition.x--;
                break;
            case dir.Right:
                newPosition.x++;
                break;
            case dir.Up:
                newPosition.y--;
                break;
            case dir.Down:
                newPosition.y++;
                break;
        }
        position = newPosition;
    }

    public void MoveWithCollision(Map map, char collider)
    {
        Position newPosition = position;
        switch (direction)
        {
            case dir.Left:
                if (map.ReturnIndex(position.x - 1, position.y) != collider)
                    newPosition.x--; 
                break;
            case dir.Right:
                if (map.ReturnIndex(position.x + 1, position.y) != collider)
                    newPosition.x++;
                break;
            case dir.Up:
                if (map.ReturnIndex(position.x, position.y - 1) != collider)
                    newPosition.y--;
                break;
            case dir.Down:
                if (map.ReturnIndex(position.x, position.y + 1) != collider)
                    newPosition.y++;
                break;
        }
        position = newPosition;
    }
}
