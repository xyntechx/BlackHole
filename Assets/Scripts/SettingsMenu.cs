using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameObject m_MainMenu;
    public GameObject m_Settings;

    public void ExitSettings()
    {
        m_Settings.gameObject.SetActive(false);
        m_MainMenu.gameObject.SetActive(true);
    }
}
