using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : Enemy
{

    public GameObject bulletGameObject;
    public AudioClip audioClip;
    private AudioSource audioSource;

    // Use this for initialization
    private void Start()
    {
        StartCoroutine(fire());
        health = 3; // Fiendens liv
        flyingSpeed = 1.25f; // Fiendens hastighet
        audioSource = GetComponent<AudioSource>();
    }

    public IEnumerator fire()
    {
        
        GameObject bullet = Instantiate(bulletGameObject, GameObject.Find("Bullets").transform, true);
        bullet.transform.position = transform.position;
        bullet.GetComponent<EnemyBullet>().right = false;
        yield return new WaitForSeconds(0.25f);
        audioSource.PlayOneShot(audioClip);
        yield return new WaitForSeconds(1);
        StartCoroutine(fire());
        
    }
}
