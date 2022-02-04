using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpritePicker : MonoBehaviour
{
    [SerializeField] List<Sprite> sprites;
    [SerializeField] SpriteRenderer spriteRenderer;
    void Awake()
    {
        int randomIndex =  Random.Range(0, sprites.Count);
        spriteRenderer.sprite = sprites[randomIndex];
    }
}
