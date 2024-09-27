using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public int maxScore = 0;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        maxScore = PlayerPrefs.GetInt("MaxScore", 0);
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString() + "\n" + "Max Score: " + maxScore.ToString();

        if (score > maxScore)
        {
            maxScore = score;
            scoreText.text = "Score: " + score.ToString() + "\n" + "Max Score: " + maxScore.ToString();
            PlayerPrefs.SetInt("MaxScore", maxScore);
        }
    }
}
