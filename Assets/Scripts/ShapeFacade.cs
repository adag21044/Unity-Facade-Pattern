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

    public void ApplyRandomTransformation(IShape shape)
    {
        if (shapeManager == null)
        {
            Debug.LogError("ShapeManager is not assigned in ShapeFacade!");
            return;
        }

        Vector3 randomDirection = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f));
        float randomSpeed = Random.Range(1f, 10f);
        float randomRotationSpeed = Random.Range(30f, 200f);
        Color randomColor = Random.ColorHSV();

        Debug.Log($"Applying random transformation: Move({randomDirection}, {randomSpeed}), Rotate(Vector3.up, {randomRotationSpeed}), Color({randomColor})");

        shapeManager.MoveShape(shape, randomDirection, randomSpeed);
        shapeManager.RotateShape(shape, Vector3.up, randomRotationSpeed);
        shapeManager.ChangeShapeColor(shape, randomColor);
    }
}
