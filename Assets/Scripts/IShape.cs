using UnityEngine;

// IShape interface declares the basic methods that a shape should have.
public interface IShape 
{
    void Move(Vector3 direction, float speed);
    void Rotate(Vector3 axis, float speed);
    void ChangeColor(Color color);
}
