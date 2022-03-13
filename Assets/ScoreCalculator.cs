using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreCalculator : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public Text scoreText;
    public void ScoreManager(int scorevalue)
    {
        score = score + scorevalue;
        Debug.Log("score: " + score);
        scoreText.text = score.ToString();
       
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
