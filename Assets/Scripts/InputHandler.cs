using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public static int X_direction;
    public static int Y_direction;
    public static bool JumpFlag;
    // Start is called before the first frame update
    void Start()
    {

        //horizontal direction
        X_direction = 0;
        //vertical direction
        Y_direction = 0;
        //is the player jumping?
        JumpFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        JumpFlag = Input.GetButtonDown("Jump");
        X_direction = (int)Input.GetAxis("Horizontal");
    }
}
