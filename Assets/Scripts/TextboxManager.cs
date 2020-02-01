using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextboxManager : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    public Image textbox;
    public Text nameText;
    public Text sentenceText;

    private Queue<string> sentences;

    private void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        textbox.enabled = true;

        Debug.Log("Starting conversation with " + dialogue.name);
        nameText.text = dialogue.name;

        player.GetComponent<PlayerMovement>().enabled = false;
        player.GetComponent<PlayerInteract>().enabled = false;

        sentences.Clear();
        foreach (string sentence in dialogue.lines)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        sentenceText.text = sentences.Dequeue();
    }

    private void EndDialogue()
    {
        Debug.Log("Ended conversation.");

        player.GetComponent<PlayerMovement>().enabled = true;
        player.GetComponent<PlayerInteract>().enabled = true;

        textbox.enabled = false;
    }
}