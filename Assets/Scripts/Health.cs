using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int health;
    private SpriteRenderer render;
    private void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        health--;
        if(health <= 0)
        {
            render.material.color = Color.gray;
        }
    }
}