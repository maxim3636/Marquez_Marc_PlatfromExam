using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Character
{
    public float protection;

    void TakeDamage(float amount)
    {
        protection -= amount;
        if (protection <= 0)
        {
            health -= amount;
            if (health <= 0)
            {
                Die();
            }
        }
    }
}
