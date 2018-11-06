using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgingEnemy : Enemy
{

    // Use this for initialization
    private void Start()
    {
        health = 3; // Fiendens liv
        flyingSpeed = 1.25f; // Fiendens hastighet
    }

    public override string ToString()
    {
        return "Spawned an dodging enemy with " + health.ToString() + " HP! Speed: " + flyingSpeed.ToString();
    }

    public void FixedUpdate()
    {
        transform.Translate(Mathf.Sin(Time.time * 4) / 28, 0.01f * flyingSpeed * 1, 0);
    }
}
