﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SpriteRenderer), typeof(Rigidbody2D))]
public class ComicFX : MonoBehaviour
{
    public float Speed = 1f;
    public Sprite[] Sprites;

    // Use this for initialization
    void Start()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        renderer.sprite = Sprites[Random.Range(0, Sprites.Length)];

        Rigidbody2D body = GetComponent<Rigidbody2D>();
        body.AddForce(Random.insideUnitCircle * Speed, ForceMode2D.Impulse);
    }
}
