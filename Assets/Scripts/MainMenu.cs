using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject m_MainMenu;
    public GameObject m_Store;
    public GameObject m_HowToPlay;
    private int randomMap;

    public void PlayGame()
    {
        randomMap = UnityEngine.Random.Range(1, 4);
        SceneManager.LoadSceneAsync(randomMap);
    }

    public void EnterStore()
    {
        m_MainMenu.gameObject.SetActive(false);
        m_Store.gameObject.SetActive(true);
    }

    public void EnterHowToPlay()
    {
        m_MainMenu.gameObject.SetActive(false);
        m_HowToPlay.gameObject.SetActive(true);
    }
}
