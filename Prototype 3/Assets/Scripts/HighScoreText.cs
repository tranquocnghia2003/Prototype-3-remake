using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScoreText : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    private float score;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        highScoreText.text = "High Score: " + Mathf.FloorToInt(PlayerPrefs.GetFloat("HighScore", 0)).ToString();
        if (!gameManager.gameOver)
        {
            score += Time.deltaTime;
        }
        GetHighestScore();
        
    }
    public void GetHighestScore()
    {
        scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();
        if(score > PlayerPrefs.GetFloat("HighScore", 0f))
        {
            PlayerPrefs.SetFloat("HighScore", score);
            highScoreText.text = "High Score: " + Mathf.FloorToInt(score).ToString(); 
        }
    }
}
