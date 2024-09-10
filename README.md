# Unity Facade Pattern

This project demonstrates the **Facade Pattern** in Unity using a shape management system, focusing on a `CubeController` object. The Facade Pattern is used to simplify interactions with the complex shape management system by providing a unified interface.

## Overview

The project contains several components that demonstrate how to manage shapes (specifically cubes) in Unity, including movement, rotation, and color changes. The **Facade Pattern** is implemented via the `ShapeFacade` class, which simplifies the interaction between the client (in this case, the `GameManager`) and the shape management system.

## Classes

### `CubeController : Shape`

This class extends the `Shape` abstract class and provides implementations for moving, rotating, and changing the cube's color.

- **ChangeColor(Color color)**: Changes the cube's material color.
- **Move(Vector3 direction, float speed)**: Moves the cube in a specified direction at the given speed.
- **Rotate(Vector3 axis, float speed)**: Rotates the cube around the specified axis at the given speed.

### `Shape`

An abstract class implementing the `IShape` interface. This class serves as the base for all shape objects (e.g., `CubeController`).

### `IShape`

An interface that declares the basic behaviors (`Move`, `Rotate`, `ChangeColor`) that all shapes must implement.

### `ShapeColorManager`

This class is responsible for managing the color of shapes. It provides a method `SetColor(IShape shape, Color color)` to change a shape's color.

### `ShapeManager`

The `ShapeManager` class is responsible for managing shape operations like movement, rotation, and color change. It uses the `ShapeColorManager` to delegate color changes.

### `ShapeFacade`

The **Facade** of the shape management system. This class provides a simplified interface for moving, rotating, and changing the color of a shape. It encapsulates the complexity of interacting with the `ShapeManager`.

### `GameManager`

The `GameManager` class demonstrates how to use the `ShapeFacade` to manipulate a `CubeController`. It performs the following actions in the `Start` method:
- Moves the cube forward with a speed of `5f`.
- Rotates the cube around the Y-axis at a speed of `100f`.
- Changes the cube's color to red.

## How It Works

The **Facade Pattern** helps simplify the shape manipulation process:
1. The `GameManager` interacts with the `ShapeFacade`, which acts as a unified interface.
2. The `ShapeFacade` delegates responsibilities to the `ShapeManager` for movement, rotation, and color changes.
3. The `ShapeManager` may further delegate specific tasks, such as changing color, to other components like the `ShapeColorManager`.

This approach hides the complexity of shape management behind a clean, easy-to-use interface, adhering to the **Facade Pattern** principles.

## Usage Example

```csharp
public class GameManager : MonoBehaviour
{
    [SerializeField] private ShapeFacade shapeFacade;
    [SerializeField] private CubeController cubeController;

    private void Start()
    {
        shapeFacade.MoveShape(cubeController, Vector3.forward, 5f);
        shapeFacade.RotateShape(cubeController, Vector3.up, 100f);
        shapeFacade.ChangeShapeColor(cubeController, Color.red);
    }
}
```
In the GameManager, we see how the facade simplifies the process of moving, rotating, and changing the color of the cube without the need to interact with multiple classes directly
