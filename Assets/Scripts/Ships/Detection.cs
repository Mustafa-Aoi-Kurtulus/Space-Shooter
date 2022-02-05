using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    [SerializeField] HealthManager health;
    [SerializeField] int damageTaken;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //If a enemy ship collides with the player ship, player takes damage
            health.TakeDamge(damageTaken);
            //The enemy ship is hidden.
            collision.gameObject.SetActive(false);
        }
    }
}
