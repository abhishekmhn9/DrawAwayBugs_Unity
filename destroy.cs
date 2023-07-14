using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private MeshCollider meshCollider;

    private void Start()
    {
        
        meshCollider = GetComponent<MeshCollider>();

        
        if (meshCollider != null && !meshCollider.enabled)
            meshCollider.enabled = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("bug"))
        {
            
            Destroy(gameObject);
        }
    }
}
