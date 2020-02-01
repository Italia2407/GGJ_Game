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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Checks if the player has entered the interactible's collision
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log.("Player has entered collsion!");
        }
    }
}
