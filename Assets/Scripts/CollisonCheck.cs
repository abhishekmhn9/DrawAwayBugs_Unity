using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CollisonCheck : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    private int score = 0;

    void AddScore() 
    {
        score++;
        scoreText.text = "SCORE: " + score;
        Debug.Log("TEST TEST TESTING");
    }

    void OnTriggerEnter2D(Collider2D edge)
    {
        if(edge.tag == "Bug")
        {
            AddScore();
            edge.gameObject.SetActive(false);
        }
    }    
}
