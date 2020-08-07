using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HTPMenu : MonoBehaviour
{
    public GameObject m_MainMenu;
    public GameObject m_HTP;

    public void ExitHTP()
    {
        m_MainMenu.gameObject.SetActive(true);
        m_HTP.gameObject.SetActive(false);
    }
}
