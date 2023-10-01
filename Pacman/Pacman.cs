using System;
using System.Runtime.CompilerServices;

public class Pacman : Character
{
	public dir queuedDir = new dir();
    /// <summary>
    /// Instantiates pacman at (0, 0)
    /// </summary>
    public Pacman()
	{
		x = 0;
		y = 0;
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
		this.x = X;
		this.y = Y;
		isDead = false;
		direction = dir.Left;
	}
}
