using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField] private Figures _figures;
    private Factory _factory;

    private void Start()
    {
        _factory = new Factory();
        _factory.Init(_figures);

        Instantiate(_factory.CreateFigureModel("sphere", 1).Figure.gameobject);
    }
}
