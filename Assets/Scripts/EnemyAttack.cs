using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    public float waitTime = 0.0f;
    public GameObject bulletEnemy;
    public GameObject spawnerLocation;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(Loop(waitTime));
        //Instantiate(bulletEnemy, spawnerLocation.transform.position, spawnerLocation.transform.rotation);
    }

    private IEnumerator Loop(float waitTime)
    {
        while (true)
        {
            GameObject bulletEnemy = ObjectPooler1.SharedInstance.GetPooledObject();
            if (bulletEnemy != null)
            {
                bulletEnemy.transform.position = spawnerLocation.transform.position;
                bulletEnemy.transform.rotation = spawnerLocation.transform.rotation;
                bulletEnemy.SetActive(true);
            }
            yield return new WaitForSeconds(waitTime);
        }
    }
}