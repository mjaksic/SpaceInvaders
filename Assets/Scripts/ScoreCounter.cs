using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour {

    public static int counter = 0;

    // Use this for initialization
    private void Start () {
	}

    private void OnCollisionEnter2D(Collision2D objToCollide)
    {
        if (objToCollide.gameObject.CompareTag("Enemy"))
        {
            counter += 20;
        }
        else if (objToCollide.gameObject.CompareTag("Bullet"))
        {
            counter += 10;
        }
    }
}
