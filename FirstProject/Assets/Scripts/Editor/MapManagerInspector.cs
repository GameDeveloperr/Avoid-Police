using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MapManager))]
public class MapManagerInspector : Editor {

    public void OnSceneGUI()
    {
        if (Application.isPlaying)
            return;
        MapManager mapManager = target as MapManager;

        Handles.BeginGUI();
        if(GUI.Button(new Rect(10, 10, 100, 30), "NORMAL"))
        {
            mapManager.curTile = mapManager._Tile[0];
        }
        if (GUI.Button(new Rect(10, 50, 100, 30), "STAIR"))
        {
            mapManager.curTile = mapManager._Tile[1];
        }
        if (GUI.Button(new Rect(10, 90, 100, 30), "TRAP"))
        {
            mapManager.curTile = mapManager._Tile[2];
        }
        if (GUI.Button(new Rect(10, 130, 100, 30), "WALL"))
        {
            mapManager.curTile = mapManager._Tile[3];
        }

        GUI.color = Color.green;
        GUI.Label(new Rect(120, 10, 500, 30), "Edit Mode : " + mapManager.curTile._type);
        GUI.color = Color.white;
        Handles.EndGUI();
    }
}
