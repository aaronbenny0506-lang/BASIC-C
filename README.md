# CSharp-Learning-Phase1

This repository documents my Phase 1 progress learning C# for Unity game
development, covering core syntax fundamentals and a first working
Unity script.

## 📄 What This Repository Contains

- `BasicsDemo.cs` — a plain C# console program covering variables & data
  types, loops (`for`, `while`), conditional statements (`if`, `switch`),
  and classes & objects.
- `RotateObject.cs` — a Unity script that rotates a GameObject continuously,
  demonstrating variables, conditionals, and Unity's `Update()` lifecycle method.

## 🧩 What My Script Does

`RotateObject.cs` rotates any GameObject it's attached to around the Y-axis.
- `rotationSpeed` controls how fast it spins (editable in the Inspector).
- `rotateClockwise` is a toggle that flips the rotation direction.
- Every frame, `Update()` applies a small rotation using `Time.deltaTime`,
  so the speed stays consistent no matter the frame rate.

## 🎮 Unity Version Used

Unity 2022 LTS (or your installed version — update this line to match
what shows in Unity Hub / Help > About Unity).

## 💡 Explanation of My Code

- **Variables & Data Types:** `rotationSpeed` (float) and `rotateClockwise`
  (bool) store the script's configurable behavior.
- **Conditional Statement:** a ternary (`? :`) picks the rotation direction
  based on the `rotateClockwise` flag.
- **Unity Lifecycle:** `Update()` is a built-in Unity method that runs once
  per frame automatically — no manual loop needed for continuous behavior.
- **`BasicsDemo.cs`** separately demonstrates the same core concepts
  (loops, conditionals, classes/objects) in plain C#, before applying
  them inside Unity.

## 📸 Screenshot

_Add a screenshot here of your Unity scene with the script attached and
running (drag the image into this repo and reference it, e.g._
`![Rotating Cube](screenshot.png)` _)._

## 🚀 How to Run

1. Open Unity Hub, create/open a project.
2. Add `RotateObject.cs` to your Assets folder.
3. Attach it to any GameObject (e.g., a Cube: GameObject > 3D Object > Cube).
4. Press Play — the object will rotate continuously.
5. (Optional) Run `BasicsDemo.cs` separately using the .NET SDK:
   ```bash
   dotnet run BasicsDemo.cs
   ```
