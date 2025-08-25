# Lights Out Game

A desktop game built with **C#** where the goal is to turn off all the lights on a grid. Each click toggles the selected light and its adjacent lights. The challenge is to find the correct sequence of moves to turn all lights off.

---

## Overview

"Lights Out" is a classic puzzle game that challenges players to turn off all the lights on the grid. Clicking on a light will toggle its state (on/off) as well as the state of neighboring lights.  

The game can be built using **Windows Forms**, **WPF**, or any C# GUI framework.

---

## How to Play

1. When starting the game, the player can choose the grid size:
   - **3x3**  
   - **4x4**  
   - **5x5**
2. Some lights start in the "on" state.  
3. Click any light to toggle it and its adjacent lights.  
4. The goal is to turn **all lights off**.  
5. After finishing a game, the player can review **previous games**, including the grid size and the number of moves used.

---

## Features

- Grid size selection: 3x3, 4x4, or 5x5.  
- Random starting configuration for replayability.  
- Undo/redo moves (optional).  
- Move counter to track the number of steps.  
- Simple and interactive GUI using C#.  
- Visual feedback for light states (on/off).  
- **Previous games review**: view a history of past games with grid size and moves used.

---

## Requirements

- **.NET 6 or higher**  
- **Visual Studio 2022 or higher**  
- C# knowledge (for customizing or extending the game)

---

## Installation & Running the Game

1. Clone the repository:
```bash
git clone https://github.com/username/lights-out-game.git
cd lights-out-game
