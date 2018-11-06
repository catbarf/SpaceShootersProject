using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FidgetSpinnerEnemy : Enemy
{
    public GameObject bulletGameObject;

    // Use this for initialization
    private void Start()
    {
        StartCoroutine(fire());
        health = 10; // Fiendens liv
        flyingSpeed = 0.075f; // Fiendens hastighet
        
    }

    public override string ToString()
    {
        return "Spawned a fidget spinner ship with " + health.ToString() + " HP! Speed: " + flyingSpeed.ToString();
    }

    public void FixedUpdate()
    {
        transform.Translate(Mathf.Sin(Time.time * 4) / 28, 0.01f * flyingSpeed * 1, 0);
        transform.Find("FidgetSpinnerShip").transform.Rotate(new Vector3(0, 0, 1));
    }

    public IEnumerator fire()
    {
        foreach (GameObject firepoint in GameObject.FindGameObjectsWithTag("Firepoint"))
        {
            GameObject bullet = Instantiate(bulletGameObject, firepoint.transform, true);
            bullet.transform.rotation = firepoint.transform.rotation;
            bullet.transform.position = firepoint.transform.position;
            bullet.GetComponent<EnemyBullet>().fidgetSpinner = true;
            yield return new WaitForSeconds(3f);
            StartCoroutine(fire());
        }
    }
}
