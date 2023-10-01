/// <summary>
/// 2D Character for console game.
/// </summary>
public class Character
{
    /// <summary>
    /// Horizontal position of the character.
    /// </summary>
    public int x { get; set; }

    /// <summary>
    /// Vertical position of the character.
    /// </summary>
    public int y { get; set; }

    /// <summary>
    /// Indicates whether the character is dead or not.
    /// </summary>
    public bool isDead { get; set; }

    public int? Health { get; set; }

    /// <summary>
    /// Direction in which the character is facing.
    /// </summary>
    public dir direction { get; set; }

    /// <summary>
    /// Enumeration defining possible directions for the character.
    /// </summary>
    public enum dir
    {
        Up, Down, Left, Right
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
            this.direction = Direction;
        }
    }

    /// <summary>
    /// Moves the character in the direction he's facing.
    /// </summary>
    /// <param name="moveDirection">The direction in which the character should move.</param>
    public void Move()
    {
        switch (direction)
        {
            case dir.Left:
                x--;
                break;
            case dir.Right:
                x++;
                break;
            case dir.Up:
                y--;
                break;
            case dir.Down:
                y++;
                break;
        }
    }

    /// <summary>
    /// Constructor for the Character class.
    /// </summary>
    public Character()
    {
    }
}
