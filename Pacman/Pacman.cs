public class Pacman : Character
{
    /// <summary>
    /// Instantiates pacman at (0, 0)
    /// </summary>
    public Pacman()
	{
        position.x = 0;
        position.y = 0;
		isDead = false;
		direction = dir.Left;
	}
	/// <summary>
	/// Instantiates pacman at desired position
	/// </summary>
	/// <param name="X">X position</param>
	/// <param name="Y">Y position</param>
	public Pacman(int X, int Y)
	{
        position.x = X; 
        position.y = Y;
		isDead = false;
		direction = dir.Left;
        queuedDir = dir.NoDir;
	}

    public void TryMoveWithCollisionAndQueuedDir(Map map, char collider)
    {
        Position newPosition = position;
        switch (queuedDir)
        {
            case dir.Left:
                if (map.ReturnIndex(position.x - 1, position.y) != collider)
                {
                    newPosition.x--; position = newPosition; direction = queuedDir; queuedDir = dir.NoDir;
                    return;
                }
                break;
            case dir.Right:
                if (map.ReturnIndex(position.x + 1, position.y) != collider)
                {
                    newPosition.x++; position = newPosition; direction = queuedDir; queuedDir = dir.NoDir;
                    return;
                }
                break;
            case dir.Up:
                if (map.ReturnIndex(position.x, position.y - 1) != collider)
                {
                    newPosition.y--; position = newPosition; direction = queuedDir; queuedDir = dir.NoDir;
                    return;
                }
                break;
            case dir.Down:
                if (map.ReturnIndex(position.x, position.y + 1) != collider)
                {
                    newPosition.y++; position = newPosition; direction = queuedDir; queuedDir = dir.NoDir;
                    return;
                }
                break;
        }
        MoveWithCollision(map, collider);
    }
}
