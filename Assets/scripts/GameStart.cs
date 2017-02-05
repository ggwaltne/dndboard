﻿using UnityEngine;
using System.Collections.Generic;


public class GameStart : MonoBehaviour
{

    public int sizex = 10;
    public int sizez = 10;
    int startX = 0;
    int startY = 0;
    public GameObject tile;
    public float spacing = .71f;
    float x = 0;
    float z = 0;

    // Use this for initialization
    void Start()
    {
        //"Assets/prefabs/BlankTile.prefab"
        PlaceMap();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlaceMap()
    { 
        PlacePieces();
    }

    private void PlacePieces()
    {
        for (int i = startX; i < sizez; i++)
        {
            for (int n = startY; n < sizex; n++)
            {
                Instantiate(tile, new Vector3(x, 0, z), Quaternion.identity);
                x = x + spacing;
            }
            x = 0;
            z -= spacing;
        }
    }
}
