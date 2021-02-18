using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

    

public class TextHandler : MonoBehaviour
{
    public ScriptableDialogue dialogueObject;

    public void LoadDialogue()
    {
        StartCoroutine(LoadText());
    }
    
    IEnumerator LoadText()
    {
        for (int i = 0; i < dialogueObject.messages.Length; i++)
        {
            Debug.Log(dialogueObject.messages[i]);
            yield return new WaitForSeconds(1f);
        }
    }
}

