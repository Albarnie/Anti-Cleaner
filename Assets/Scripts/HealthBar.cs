using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public GameObject healthBarPrefab, healthBar;
    public int amount;
    public Vector3 offset;

    public void UpdateHealth (int newAmount)
    {
        if(healthBar == null)
        {
            healthBar = Instantiate(healthBarPrefab, transform.position + offset, Quaternion.identity, transform);
        }
        amount = newAmount;

        Vector2 size = healthBar.GetComponent<SpriteRenderer>().size;
        size.x = amount;
        healthBar.GetComponent<SpriteRenderer>().size = size;
    }
}
