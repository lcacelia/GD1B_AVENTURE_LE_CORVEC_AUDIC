using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dialogue_Manager : MonoBehaviour
{

    public Text nameText;
    public Text dialoguetext;
    
    public static Dialogue_Manager instance;
    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("Il ya plus d'une instance de dialoguemanager dans la scene");
            return;
        }
        instance = this;
    }
    public void StartDialogue(Dialogue dialogue)
    {
        nameText.text = dialogue.name;
    }
}
