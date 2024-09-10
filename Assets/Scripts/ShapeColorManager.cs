using UnityEngine;

// ShapeColorManager class is responsible for changing the color of a shape.
public class ShapeColorManager : MonoBehaviour
{
    public void SetColor(IShape shape, Color color)
    {
        shape.ChangeColor(color);
    }
}