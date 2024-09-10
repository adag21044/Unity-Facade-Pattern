using UnityEngine;

public abstract class Shape : MonoBehaviour, IShape
{
    public abstract void ChangeColor(Color color);
    public abstract void Move(Vector3 direction, float speed);
    public abstract void Rotate(Vector3 axis, float speed);   
}