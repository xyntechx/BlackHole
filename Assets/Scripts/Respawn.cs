using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private void OnEnable()
    {
        Reappear();
    }

    void Update()
    {
        if (transform.position.y < -8.5)
        {
            Reappear();
        }
    }

    private void Reappear()
    {
        float randomX = UnityEngine.Random.Range(7, -7);
        float randomY = UnityEngine.Random.Range(1, -2);
        transform.position = new Vector2(randomX, randomY);
        var rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector3.zero;
    }
}
