using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionPopUp : MonoBehaviour
{
    public GameObject instructionPanel; // Reference to the panel object

    void Start()
    {
        // Show the panel when the game starts
        instructionPanel.SetActive(true);
    }

    public void CloseInstructions()
    {
        // Hide the panel when the button is clicked
        instructionPanel.SetActive(false);
    }
}
