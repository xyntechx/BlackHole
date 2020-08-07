using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScoreTracker : MonoBehaviour
{
    public TextMeshProUGUI HighScore;
    private int highScore;
    private int score;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
        score = PlayerPrefs.GetInt("Score");

        if (highScore > score)
        {
            HighScore.text = highScore.ToString();
        }
    }
}
