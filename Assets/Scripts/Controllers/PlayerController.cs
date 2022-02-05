using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static int score = 0;
    [SerializeField] ObjectPool objectPool;
    [SerializeField] Transform bulletPoint;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed;
    [SerializeField] float attackCooldown;
    private void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            FireBullets();
        }
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(GetInput() * speed, 0);
    }
    float GetInput()
    {
        return Input.GetAxis("Horizontal");
    }

    void FireBullets()
    {
        GameObject bullet = objectPool.GetPooledObject(0);
        bullet.transform.position = bulletPoint.position;
        bullet.transform.parent = bulletPoint.transform;
    }
}
