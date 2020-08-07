using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CharacterController2D : MonoBehaviour
{
    [SerializeField] private float m_JumpForce = 400f;

    private Rigidbody2D m_Rigidbody2D;
    private Vector3 m_Velocity = Vector3.zero;
    private int count = 0;
    private float m_MovementSmoothing = .05f;
    private bool m_AirControl = true;
    public TextMeshProUGUI CoinsCollected;
    

    void Start()
    {
        CoinsCollected.text = count.ToString();
    }

    [Header("Events")]
    [Space]

    public UnityEvent OnLandEvent;

    [System.Serializable]
    public class BoolEvent : UnityEvent<bool> { }

    private void Awake()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();

        if (OnLandEvent == null)
            OnLandEvent = new UnityEvent();
    }

    public void Move(float move, bool jump)
    {
        Vector3 targetVelocity = new Vector2(move * 10f, m_Rigidbody2D.velocity.y);
        m_Rigidbody2D.velocity = Vector3.SmoothDamp(m_Rigidbody2D.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);

        if (jump)
        {
            m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            count++;
            CoinsCollected.text = count.ToString();
            PlayerPrefs.SetInt("CoinsCollected", count);
        }
        else if (other.gameObject.CompareTag("BlackHole"))
        {
            SceneManager.LoadSceneAsync(5);
        }
    }
}