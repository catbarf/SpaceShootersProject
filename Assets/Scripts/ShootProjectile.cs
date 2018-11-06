using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShootProjectile : MonoBehaviour
{
    public GameObject lasershot;
    public AudioClip fireSound;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    void Update()
    {
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                GameObject clone = Instantiate(lasershot, GameObject.Find("Bullets").transform, true);
                clone.transform.position = transform.position + new Vector3(0.9f, 0, 0);
                clone.name = "lasershot";
                audioSource.PlayOneShot(fireSound);
            }
        }
    }
}