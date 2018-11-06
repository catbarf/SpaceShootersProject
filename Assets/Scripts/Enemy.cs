using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int health = 1; // Fiendens liv
    public float flyingSpeed = 1; // Fiendens hastighet
    public int damage = 10;


    private void Start()
    {
        Debug.Log(ToString());
    }

    public override string ToString()
    {
        return "Spawned an enemy with " + health.ToString() + " HP! Speed: " + flyingSpeed.ToString();
    }

    private void Update()
    {
        if (health <= 0)
        {
            Data.score += 1 * (1 * Random.Range(1, 5));
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector2.up / 100 * flyingSpeed * 1);
        
    }

    

}
