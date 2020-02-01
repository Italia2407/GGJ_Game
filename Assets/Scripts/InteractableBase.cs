using UnityEngine;

public class InteractableBase : MonoBehaviour
{
    private bool canInteract = false;

    public bool CanInteract { get => canInteract; }

    public void Interact()
    {
        Destroy(gameObject);
    }
}
