using UnityEngine;

public class ShapeFacade : MonoBehaviour
{
    [SerializeField] private ShapeManager shapeManager;

    public void MoveShape(IShape shape, Vector3 direction, float speed)
    {
        shapeManager.MoveShape(shape, direction, speed);
    }

    public void RotateShape(IShape shape, Vector3 axis, float speed)
    {
        shapeManager.RotateShape(shape, axis, speed);
    }

    public void ChangeShapeColor(IShape shape, Color color)
    {
        shapeManager.ChangeShapeColor(shape, color);
    }
}