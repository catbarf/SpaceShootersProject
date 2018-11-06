using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{

    private Material material;
    public float scrollSpeed;

    private void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    private void Update()
    {
        material.SetTextureOffset("_MainTex", new Vector2(Time.time * scrollSpeed, 0));
    }
}
