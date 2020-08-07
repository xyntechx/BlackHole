using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    private void OnEnable()
    {
        Reappear();
    }

    void Update()
    {
        if (transform.position.y < -30)
        {
            Reappear();
        }
    }

    private void Reappear()
    {
        float randomX = UnityEngine.Random.Range(34, -35);
        float randomY = UnityEngine.Random.Range(5, -5);
        transform.position = new Vector2(randomX, randomY);
        var rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector3.zero;
    }
}
