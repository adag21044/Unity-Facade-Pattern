using UnityEngine;

// ShapeManager class is responsible for managing shapes.
public class ShapeManager : MonoBehaviour
{
    private ShapeColorManager colorManager;

    private void Awake()
    {
        if (colorManager == null)
        {
            colorManager = FindObjectOfType<ShapeColorManager>();
        }

         if (colorManager == null)
        {
            Debug.LogError("ShapeColorManager is missing! Assign it in the inspector.");
        }
    }

    public void MoveShape(IShape shape, Vector3 direction, float speed)
    {
        shape.Move(direction, speed);
    }

    public void RotateShape(IShape shape, Vector3 axis, float speed)
    {
        shape.Rotate(axis, speed);
    }

    public void ChangeShapeColor(IShape shape, Color color)
    {
        if (colorManager != null)
        {
            colorManager.SetColor(shape, color);
        }
        else
        {
            Debug.LogError("Cannot change color: ShapeColorManager is null!");
        }
    }
}