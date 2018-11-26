using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Tiles
{
    public TILETYPE _type;
    public Transform _tile;
}

public class MapManager : MonoBehaviour {
    public Tiles[] _Tile;

    public Tiles curTile;
}
