/*
 * PlayerMovement.cs
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D player = null;

    public float movementRate = 5f;
    public float JumpForce = 10f;

    // Local variables used by the whole script
    private float horizontalMove = 0.0f;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
            player.velocity = new Vector2(player.velocity.x,JumpForce);
    }

    private void FixedUpdate()
    {
        if (horizontalMove != 0.0f)
        {
            float hor = horizontalMove * movementRate * (Time.deltaTime * 100.0f);
            player.velocity = new Vector2(hor, player.velocity.y);
        }

        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.velocity = new Vector2(player.velocity.x, 4.0f);
        }
        */
    }
}
