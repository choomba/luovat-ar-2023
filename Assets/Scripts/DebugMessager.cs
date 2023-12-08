using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMessager : MonoBehaviour
{
    public string debugMessage;

    public void PrintDebugMessage()
    {
        PrintDebugMessage(debugMessage);
    }

    public void PrintDebugMessage(string message)
    {
        Debug.Log(message);
    }

}
