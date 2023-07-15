using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BugDestroy : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    private int score = 0;

    private void Start()
    {
        score = 0;
    }

    void AddScore()
    {
        score++;
        scoreText.text = "SCORE: " + score;
        Debug.Log("TEST TEST TESTING");
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.GetType() == typeof(EdgeCollider2D))
        {
            
            Destroy(gameObject);
        }
    }

  










}


