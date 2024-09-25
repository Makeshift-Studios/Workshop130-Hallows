using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestNPC : NPC, ITalkable
{
    [SerializeField] private DialogueText dialogueText;
    [SerializeField] private DialogueController dialogueController;
    public override void Interact(Interactor interactor, out bool interactSuccessful)
    {
        Talk(dialogueText);
        interactSuccessful = true;
        Debug.Log("NPC Interact Successful");
    }

    public void Talk(DialogueText dialogueText)
    {
        dialogueController.DisplayNextParagraph(dialogueText);
    }
}
