using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class SpawnBug : MonoBehaviour
{
    public GameObject bugPrefab;
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
        Instantiate(bugPrefab, new Vector2(Random.Range(-2.27f,2.27f), Random.Range(-4.97f, 4.97f)), Quaternion.identity);
        Destroy(gameObject, 0.75f);  

      /*var wanted = Random.Range(minTras, maxtras);
      var position = new Vector3(wanted, transform.position.y);
        Instantiate(bugPrefab, position, Quaternion.identity);
      //WaitForSeconds(secondSpawn);
      Destroy(gameObject, 2.0f);*/



    }
}
