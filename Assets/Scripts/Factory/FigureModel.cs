using UnityEngine;

public class FigureModel
{
    private Figure _figure;
    private GameObject _gameobject;

    public Figure Figure => _figure;

    public FigureModel(Figure figure)
    {
        _figure = figure;
        _gameobject = _figure.gameobject;
        _gameobject.GetComponent<MeshRenderer>().material = _figure.material;
    }
}
