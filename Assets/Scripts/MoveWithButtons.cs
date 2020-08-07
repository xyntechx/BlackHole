using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MoveWithButtons : MonoBehaviour
{
    private Rigidbody2D rb;
    private float dirX;
    private float dirY;
    private float moveSpeed = 100f;
    private float jumpStrength = 40f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;
        dirY = CrossPlatformInputManager.GetAxis("Vertical") * jumpStrength;
        rb.velocity = new Vector2(dirX, dirY);
    }
}
