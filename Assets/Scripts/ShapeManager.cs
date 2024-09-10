using UnityEngine;

// ShapeManager class is responsible for managing shapes.
public class ShapeManager : MonoBehaviour
{
    private ShapeColorManager colorManager;

    private void Awake()
    {
        colorManager = GetComponent<ShapeColorManager>();
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
        colorManager.SetColor(shape, color);
    }
}