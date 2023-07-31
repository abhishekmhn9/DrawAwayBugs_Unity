using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyable_object : MonoBehaviour
{
    public int scoreValue = 1; // The score value to be added when this object is destroyed

    private BugDestroy bugDestroy;

    private void Start()
    {
        
        bugDestroy = FindObjectOfType<BugDestroy>();
    }

    private void OnDestroy()
    {
       
        if (bugDestroy != null)
        {
            bugDestroy.AddScore(scoreValue); 
        }
    }
}

