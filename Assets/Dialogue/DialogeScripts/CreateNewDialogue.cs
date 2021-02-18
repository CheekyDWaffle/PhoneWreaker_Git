using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewDialogue : MonoBehaviour
{
    [CreateAssetMenu(fileName = "New Dialogue", menuName ="Dialogue/New Dialogue")]
    public class DialogueData : Dialogue { }
}
