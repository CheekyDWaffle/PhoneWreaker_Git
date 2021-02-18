using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ScriptableDialogue : ScriptableObject {
    public int npcID;
    public string npcName;
    public Message[] messages;
}
