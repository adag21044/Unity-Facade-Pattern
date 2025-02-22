using UnityEngine;
using TMPro;

public class CubeController : Shape
{
    public TextMeshProUGUI debugText; // Logları göstermek için TextMeshPro
    private Vector3 movementDirection;
    private Vector3 rotationAxis;
    private float movementSpeed;
    private float rotateSpeed;

    public override void ChangeColor(Color color)
    {
        GetComponent<Renderer>().material.color = color;

        
        if (debugText != null)
            debugText.text += $"Color changed to {color}\n";
        
        Debug.Log($"Color changed to {color}"); 
    }

    public override void Move(Vector3 direction, float speed)
    {
        movementDirection = direction;
        movementSpeed = speed;

        // Yeni mesajı ekle
        if (debugText != null)
            debugText.text += $"Moving to {direction} with speed {speed}\n";

        Debug.Log($"Moving to {direction} with speed {speed}"); // Konsola log ekle
    }

    public override void Rotate(Vector3 axis, float speed)
    {
        rotationAxis = axis;
        rotateSpeed = speed;

        // Yeni mesajı ekle
        if (debugText != null)
            debugText.text += $"Rotating around {axis} with speed {speed}\n";

        Debug.Log($"Rotating around {axis} with speed {speed}"); // Konsola log ekle
    }

    private void Update()
    {
        // Hareket ve dönüş işlemlerini gerçekleştir
        transform.Translate(movementDirection * movementSpeed * Time.deltaTime);
        transform.Rotate(rotationAxis, rotateSpeed * Time.deltaTime);
    }
}
