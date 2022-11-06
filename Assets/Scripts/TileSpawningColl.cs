using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawningColl : MonoBehaviour
{
    public GameObject RefTile;
    public GameObject EZTile;
    public GameObject EZTileVar1;
    public GameObject EZTileVar2;
    public GameObject INTTile;
    public GameObject INTTileVar1;
    public GameObject INTTileVar2;
    public GameObject HARDTile;
    public GameObject HARDTileVar1;
    public GameObject HARDTileVar2;
    public Transform TilePlace;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Tile"))
        {
            int TileDiff = Random.Range(1, 4);
            if(TileDiff == 1)
            {
                int Tile1OP = Random.Range(1, 4);
                if (Tile1OP == 1)
                {
                    Debug.Log("1");
                    Instantiate(EZTile, TilePlace.position, transform.rotation);
                }
                if (Tile1OP == 2)
                {
                    Debug.Log("2");
                    Instantiate(EZTileVar1, TilePlace.position, transform.rotation);
                }
                if (Tile1OP == 3)
                {
                    Debug.Log("3");
                    Instantiate(EZTileVar2, TilePlace.position, transform.rotation);
                }
                
            }
            if (TileDiff == 2)
            {
                int Tile2OP = Random.Range(1, 4);
                if (Tile2OP == 1)
                {
                    Debug.Log("4");
                    Instantiate(INTTile, TilePlace.position, transform.rotation);
                }
                if (Tile2OP == 2)
                {
                    Debug.Log("5");
                    Instantiate(INTTileVar1, TilePlace.position, transform.rotation);
                }
                if (Tile2OP == 3)
                {
                    Debug.Log("6");
                    Instantiate(INTTileVar2, TilePlace.position, transform.rotation);
                }

            }
            if (TileDiff == 3)
            {
                int Tile3OP = Random.Range(1, 4);
                if (Tile3OP == 1)
                {
                    Debug.Log("7");
                    Instantiate(HARDTile, TilePlace.position, transform.rotation);
                }
                if (Tile3OP == 2)
                {
                    Debug.Log("8");
                    Instantiate(HARDTileVar1, TilePlace.position, transform.rotation);
                }
                if (Tile3OP == 3)
                {
                    Debug.Log("9");
                    Instantiate(HARDTileVar2, TilePlace.position, transform.rotation);
                }

            }
        }
    }
}
