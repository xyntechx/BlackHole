using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopMenu : MonoBehaviour
{
    public GameObject m_MainMenu;
    public GameObject m_Shop;
    public GameObject SkinPanel;

    public void ExitShop()
    {
        m_MainMenu.gameObject.SetActive(true);
        m_Shop.gameObject.SetActive(false);
    }
}
