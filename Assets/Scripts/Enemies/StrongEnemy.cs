using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongEnemy : Enemy
{

    private void Start()
    {
        health = 4; // Fiendens liv
        flyingSpeed = 1; // Fiendens hastighet
    }

    public override string ToString()
    {
        return "Spawned an strong enemy with " + health.ToString() + " HP! Speed: {flyingSpeed.ToString()}";
    }
}
