using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    float startPos;
    [SerializeField] BoxCollider2D coll;
    void Awake()
    {
        startPos = transform.position.y;
    }
    void Update()
    {
        float currentPosition = transform.position.y;
        if (startPos - currentPosition >= GetRange())
        {
            transform.position = new Vector2(0, startPos);
        }
    }
    float GetRange()
    {
        return coll.size.y / 2;
    }
}
