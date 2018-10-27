using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HealthBar))]
public class Destroyable : MonoBehaviour
{
    HealthBar healthBar;

    public int health = 100;

    private void Awake()
    {
        healthBar = GetComponent<HealthBar>();
    }

    public void Damage (int amount)
    {
        health -= amount;

        healthBar.amount = health;

        if(health <= 0)
        {
            Die();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Damage((int)collision.relativeVelocity.magnitude * 5);
    }

    public void Die ()
    {

    }
}
