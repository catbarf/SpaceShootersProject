using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : Enemy
{
    public override string ToString()
    {
        return "Spawned an basic enemy with " + health.ToString() + " HP! Speed: " + flyingSpeed.ToString();
    }
}
