using UnityEngine;

public class ShapeFacade : MonoBehaviour
{
    [SerializeField] private ShapeManager shapeManager;

    private void Awake()
    {
        if (shapeManager == null)
        {
            shapeManager = FindObjectOfType<ShapeManager>();
        }

        if (shapeManager == null)
        {
            Debug.LogError("ShapeManager is missing! Assign it in the inspector.");
        }
    }

    public void MoveShape(IShape shape, Vector3 direction, float speed)
    {
        if (shapeManager != null)
        {
            shapeManager.MoveShape(shape, direction, speed);
        }
    }

    public void RotateShape(IShape shape, Vector3 axis, float speed)
    {
        if (shapeManager != null)
        {
            shapeManager.RotateShape(shape, axis, speed);
        }
    }

    public void ChangeShapeColor(IShape shape, Color color)
    {
        if (shapeManager != null)
        {
            shapeManager.ChangeShapeColor(shape, color);
        }
    }
}
