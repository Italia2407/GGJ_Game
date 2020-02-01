using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private List<InteractableBase> InteractableItems;

    private void Start()
    {
        InteractableItems = new List<InteractableBase>();
    }

    private void Update()
    {
        Debug.Log(InteractableItems.Count);

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (InteractableItems.Count != 0)
            {
                int index = InteractableItems.Count - 1;
                InteractableItems[index].Interact();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        InteractableBase interactable = collision.gameObject.GetComponent<InteractableBase>();

        if (interactable != null)
        {
            InteractableItems.Add(interactable);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        InteractableBase interactable = collision.gameObject.GetComponent<InteractableBase>();

        if (interactable != null)
        {
            InteractableItems.Remove(interactable);
        }
    }
}