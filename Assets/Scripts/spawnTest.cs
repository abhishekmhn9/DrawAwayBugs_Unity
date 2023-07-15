using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawnTest : MonoBehaviour
{
    public GameObject BugPrefab;
    private float minX = -2.2f;
    private float maxX = 2.2f;
    void Start()
    {
        StartCoroutine (SpawnBug());
    }

    IEnumerator SpawnBug()
    {
       yield return new WaitForSeconds(Random.Range(0f, 2.0f));

       Instantiate(BugPrefab, new Vector2(Random.Range(minX, maxX), transform.position.y), Quaternion.identity);

       StartCoroutine (SpawnBug()); 
    }


    /*   public GameObject bugPrefab;
       public float secondSpawn = 5.0f;
       public float minTras;
       public float maxTras;

       void Start()
       {
           StartCoroutine(bugSpawn());
       }

       IEnumerator bugSpawn()
       {
           yield return new WaitForSeconds(Random.Range(0f, 1.5f));
           Instantiate(bugPrefab, new Vector3(Random.Range(-2.27f, 2.27f), transform.position.y, Quaternion.identity);
           Destroy(gameObject, 0.75f);
       }*/

}
