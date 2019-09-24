using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler1 : MonoBehaviour {

    public static ObjectPooler1 SharedInstance;
    public List<GameObject> pooledObjects;
    public GameObject objectToPool;
    public int amountToPool;

    public GameObject GetPooledObject()
    {
        
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
          
        return null;
    }

    void Awake()
    {
        SharedInstance = this;
    }

    // Use this for initialization
    void Start () {
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = (GameObject)Instantiate(objectToPool);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }

    }

}
