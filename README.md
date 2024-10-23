# 🟡 Pacman Console Game

Pacman console game! The classic arcade game, built entirely in C#

## 🎮 Project Overview

Build using ASCII. The game mechanics include:

- **Move Pacman around the map** using WASD or arrow keys.
- **Avoid walls** and navigate through the maze.
- **Eat dots** to score points—no ghosts (yet!)

## 💻 How It Works

The project is broken down into a few core classes, each responsible for a different aspect of the game:

### 1. **Character.cs**
   - Defines a 2D character with movement logic.
   - Manages input, direction, and collision detection for characters on the map.

### 2. **Pacman.cs**
   - Extends the *Character* class to add Pacman-specific behavior.
   - Includes collision logic, movement queuing, and start position.

### 3. **Map.cs**
   - Reads the map from the `Map.txt` file and converts it into a grid of characters.
   - Handles map rendering and printing, complete with walls, dots, and Pacman.
   - Allows for modifications of the map as Pacman moves around.

### 4. **Program.cs**
   - The entry point of the game.
   - Handles the game loop, user input, and console rendering.

### 5. **Map.txt**
   - The game map is defined in this text file, with characters representing different elements:
     - `0`: Wall
     - `1`: Empty space
     - `2`: Dot
     - `3`: Power pellet (not implemented yet, but I'm working on it!)
     - `4`: Warp point (for future updates)
     - `5`: Pacman (start position)

## 🛠️ Setting Up

Ready to dive into the maze? Here’s how to get started:

1. **Clone this repo:**
   ```bash
   git clone https://github.com/yourusername/pacman-console-game.git
   ```
2. Open the project in Visual Studio or your favorite C# IDE.

3. Build and run the solution.

4. Use WASD or the arrow keys to move Pacman around.

   Will make an executable later!
