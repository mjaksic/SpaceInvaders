using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.0f;
    public GameObject bullet;
    public GameObject spawnerLocation;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate(bullet, spawnerLocation.transform.position, Quaternion.identity);
            GameObject bullet = ObjectPooler.SharedInstance.GetPooledObject();
            if (bullet != null)
            {
                bullet.transform.position = spawnerLocation.transform.position;
                bullet.transform.rotation = spawnerLocation.transform.rotation;
                bullet.SetActive(true);
            }
        }
    }

    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            if (gameObject.tag == "Player")
            {
                gameObject.SetActive(false);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}