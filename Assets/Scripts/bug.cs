using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bug : MonoBehaviour
{
    public GameObject bugPrefab;
    public float secondSpawn = 5.0f;
    public  float minTras;
    public  float maxtras;

    void Start()
    {
        StartCoroutine(bugSpawn());
    }

    void bugSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxtras);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(bugPrefab[Random.Range(0, bugPrefab.Length)], position, Quaternion.identity);
            yeild return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 10f);
        }
    }
}
