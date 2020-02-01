/*
 * Interactable.cs
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField]
    private BoxCollider2D interactZone;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        // Checks if the player has entered the interactible's collision
        if (collision.tag == "Player")
        {

            Debug.Log("Player has entered collsion!");

            if (Input.GetKeyDown(KeyCode.E))
                Interact();


        }
    }

    protected void Interact()
    {
        Debug.Log("Player has entered collsion!");
    }
}
