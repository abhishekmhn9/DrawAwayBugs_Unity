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
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bug")
        {
            AddScore();
            collision.gameObject.SetActive(false);
        }
    }    
}
