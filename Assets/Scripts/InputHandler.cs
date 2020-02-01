/*
    InputHandler.cs
    This script is will update every frame, and detect the user's input.
    This script is accessable across all modules. Access the script using InputHander._________ if you want to access something
    Is only intended to process input and nothing else
    Will ONLY be attached to the MainHandler Object
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    /*
    Variables:
    X_direction = will detect which direction the player is facing
    Y_direction = will detect whether the player is going up or down. Note: May end up being redundant
    JumpFlag = will detect if the user has pressed the jump button
    Interact Flag = will detect if the player is pressed the interact button (left shift)
    */


    public static int X_direction;
    public static int Y_direction;
    public static bool JumpFlag, InteractFlag;

    // Start is called before the first frame update. Called at the beginning of the program to declare variables
    void Start()
    {

        //horizontal direction
        X_direction = 0;
        //vertical direction
        Y_direction = 0;
        //is the player jumping?
        JumpFlag = false;
        //is the player interacting with an object?
        InteractFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        - Get which buttons the player is pressing
        */
        JumpFlag = Input.GetButtonDown("Jump");
        InteractFlag = Input.GetButtonDown("Fire3");
        if (Input.GetAxis("Horizontal") > 0)
        { X_direction = 1; }
        else if (Input.GetAxis("Horizontal") < 0)
        { X_direction = -1; }
        else
        {
            X_direction = 0;
        }
        
    }
}
