using System;
using System.Collections.Generic;
using UnityEngine;


public class Factory
{
    private Dictionary<string, Func<int, FigureModel>> _figureFactory;

    public void Init(Figures figures)
    {
        _figureFactory = new Dictionary<string, Func<int, FigureModel>>()
        {
            {"cube", i => new FigureModel(figures.ListCube[i]) },
            {"sphere", i =>  new FigureModel(figures.ListSphere[i])}
        };
    }

    public FigureModel CreateFigureModel(string name, int i)
    {
        return _figureFactory [name](i);
    }
}
