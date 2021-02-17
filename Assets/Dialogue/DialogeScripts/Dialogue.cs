using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
    public class Dialogue : ScriptableObject {
        public int npcID;
        public string npcName;
        public Message[] messages;
        
        
    }
[CreateAssetMenu(fileName = "New Dialogue", menuName ="Dialogue/New Dialogue")]
public class DialogueData : Dialogue { }
    

