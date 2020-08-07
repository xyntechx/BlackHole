using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowScore : MonoBehaviour
{
    Timer score;
    public TextMeshProUGUI Score;
    public TextMeshProUGUI CoinsCollected;

    // Start is called before the first frame update
    void Start()
    {
        Score.text = PlayerPrefs.GetInt("Score").ToString();
        CoinsCollected.text = PlayerPrefs.GetInt("CoinsCollected").ToString();
    }
}
