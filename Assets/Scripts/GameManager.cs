using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ShapeFacade shapeFacade;
    [SerializeField] private CubeController cubeController;

    private void Start()
    {
        shapeFacade.ApplyRandomTransformation(cubeController);
    }
}