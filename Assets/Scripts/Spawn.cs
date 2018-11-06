using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject ship1;
    public GameObject ship2;

    private void Start()
    {
        if (Data.ship == 1)
        {
            GameObject clone = Instantiate(ship1, GameObject.Find("Player").transform, true);
            clone.transform.position = new Vector3(-10, 0, 0);
        }
        else if (Data.ship == 2)
        {
            GameObject clone = Instantiate(ship2, GameObject.Find("Player").transform, true);
            clone.transform.position = new Vector3(-10, 0, 0);
        }
        
    }
}
