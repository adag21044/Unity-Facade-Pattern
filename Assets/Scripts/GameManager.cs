using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ShapeFacade shapeFacade;
    [SerializeField] private CubeController cubeController;

    private void Start()
    {
        shapeFacade.MoveShape(cubeController, Vector3.forward, 5f);
        shapeFacade.RotateShape(cubeController, Vector3.up, 100f);
        shapeFacade.ChangeShapeColor(cubeController, Color.red);
    }
}