using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkingNPC : InteractableBase
{
    public Dialogue dialogue;

    public override void Interact()
    {
        base.Interact();

        FindObjectOfType<TextboxManager>().StartDialogue(dialogue);
    }
}
