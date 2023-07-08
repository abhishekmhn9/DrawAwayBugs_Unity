using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; 

    public void SpawnObject(Vector3 position)
    {
        Instantiate(objectToSpawn, position, Quaternion.identity);
    }
}
