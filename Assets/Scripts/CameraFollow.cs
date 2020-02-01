/*
 * CameraFollow.cs
 * 
 * Allows for the camera to follow the player 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform player = null;

    public Vector3 offset = new Vector3(0.0f, 0.0f, -10.0f);

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
