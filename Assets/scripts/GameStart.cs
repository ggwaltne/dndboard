using UnityEngine;
using System.Collections.Generic;


public class GameStart : MonoBehaviour
{

    public int sizex = 10;
    public int sizez = 10;
    int startX = 0;
    int startY = 0;
    public GameObject blacktile;
    public GameObject whitetile;
    public float spacing = .71f;
    float x = 0;
    float z = 0;
    public Camera camera;

    // Use this for initialization
    void Start()
    {
        //"Assets/prefabs/BlankTile.prefab"
        PlaceMap();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            // if left button pressed...
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {

                if(hit.collider.gameObject.name.Equals("BlackTile(Clone)"))
                { 
                    Instantiate(whitetile, hit.collider.transform.position, hit.collider.transform.rotation);
                }
                else
                {
                    Instantiate(blacktile, hit.collider.transform.position, hit.collider.transform.rotation);
                }
                // the object identified by hit.transform was clicked
                // do whatever you want
                Destroy(hit.collider.gameObject);
            }
        }
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
                Instantiate(blacktile, new Vector3(x, 0, z), Quaternion.identity);
                x = x + spacing;
            }
            x = 0;
            z -= spacing;
        }
    }
}
