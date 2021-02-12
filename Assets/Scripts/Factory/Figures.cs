using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Figures", menuName = "Figures")]
public class Figures : ScriptableObject
{
    [SerializeField] private List<Figure> _listCube;
    [SerializeField] private List<Figure> _listSphere;

    public List<Figure> ListCube => _listCube;
    public List<Figure> ListSphere => _listSphere;
}
