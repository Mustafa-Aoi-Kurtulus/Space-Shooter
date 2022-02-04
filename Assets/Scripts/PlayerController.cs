using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed;
    void FixedUpdate()
    {
        rb.velocity = new Vector2(GetInput() * speed, 0);
    }
    float GetInput()
    {
        return Input.GetAxis("Horizontal");
    }
}
