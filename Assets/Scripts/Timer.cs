using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timer;
    int timescore;

    // Start is called before the first frame update
    void Start()
    {
        timer = GetComponent<TextMeshProUGUI>();
        SetHighScore();
    }

    // Update is called once per frame
    void Update()
    {
        timescore++;
        timer.text = timescore.ToString();
        PlayerPrefs.SetInt("Score", timescore);
        SetHighScore();
    }

    public void SetHighScore()
    {
        if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", timescore);
        }
    }
}
