using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] int bulletDamage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            DealDamage(collision);
            IncreaseScore();
        }
    }

    void IncreaseScore()
    {
        PlayerController.score += bulletDamage;
    }

    private void DealDamage(Collider2D collision)
    {
        //Hide the bullet object
        gameObject.SetActive(false);
        //Damage Enemy ship
        HealthManager enemyShip = collision.gameObject.GetComponent<HealthManager>();
        enemyShip.TakeDamge(bulletDamage);
    }
}
