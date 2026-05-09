# Hyper Casual Progress Bar - Unity

A simple and reusable progress bar system for Hyper Casual games made with Unity.

## Screenshot

![Progress Bar Screenshot](Assets/Screenshots/Screenshot%201.png)

---

## Features

- Clean and lightweight system
- Event-driven architecture
- Easy to integrate into any Hyper Casual project
- Automatically updates the progress bar when the player moves
- Modular and reusable scripts

---

## How It Works

This system uses C# events for communication between scripts.

### Flow

1. The player movement script detects movement.
2. When the player moves, it fires an event.
3. The `ProgressBarManager` script listens to that event.
4. Once the event is received, the progress bar value is updated.

This approach keeps the code decoupled and easier to maintain.

---

## Example Architecture

### Player Movement

The player movement script fires an event:

```csharp
public static event Action<float> OnPlayerMouvement;
