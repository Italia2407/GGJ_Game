/*
Movement.cs
This will move the player depending on the input of the script InputHandler.cs
This Script is accessible across all scripts using Movement._________
Must only be declared on Main Handler object
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    /*
    Variables:
    instance - itself (do not touch this)
    player - for the player's movement
    rateofMovement - the speed of the player

    */
    public static Movement instance;
    public static Rigidbody2D player;
    public static float RateOfMovement;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        //rate of movement is declared here
        RateOfMovement = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        //if the player isn't found
        if (player == null)
        {
            //find the object the player's rigid body is attached to
            GameObject playerbaseclass = GameObject.Find("Test Player");
            //if found
            if (playerbaseclass != null)
            {
                //declare player
                player = playerbaseclass.GetComponent<Rigidbody2D>();

            }
            else
            {
                Debug.LogErrorFormat("Player has not been found);
            }
        }
        //now if player is found
        if (player != null)
        {
            //move player horizontally depending on the input
            player.velocity = new Vector2(InputHandler.X_direction * RateOfMovement, player.velocity.y); 
        }

    }
}
