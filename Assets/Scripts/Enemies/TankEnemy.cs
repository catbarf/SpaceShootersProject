using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEnemy : Enemy
{

    private void Start()
    {
        health = 30; // Fiendens liv
        flyingSpeed = 0.75f; // Fiendens hastighet
    }

    public override string ToString()
    {
        return "Spawned an tank enemy with " + health.ToString() + " HP! Speed: " + flyingSpeed.ToString();
    }

}
