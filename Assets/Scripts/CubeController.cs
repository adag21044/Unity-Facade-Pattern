using UnityEngine;

public class CubeController : Shape
{
    private Vector3 movementDirection;
    private Vector3 rotationAxis;
    private float movementSpeed;
    private float rotateSpeed;

    public override void ChangeColor(Color color)
    {
        GetComponent<Renderer>().material.color = color;
    }

    public override void Move(Vector3 direction, float speed)
    {
        movementDirection = direction;
        movementSpeed = speed;
    }

    public override void Rotate(Vector3 axis, float speed)
    {
        rotationAxis = axis;
        rotateSpeed = speed;
    }

    private void Update()
    {
        transform.Translate(movementDirection * movementSpeed * Time.deltaTime);
        transform.Rotate(rotationAxis, rotateSpeed * Time.deltaTime);
    }
}