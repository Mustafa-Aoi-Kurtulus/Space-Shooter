using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int health;

    void Update()
    {
        //If the health is 0 or below, hide the object until it will be called in object pool queue
        if (health <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    public void TakeDamge(int damageAmount)
    {
        health -= damageAmount;
    }
}
