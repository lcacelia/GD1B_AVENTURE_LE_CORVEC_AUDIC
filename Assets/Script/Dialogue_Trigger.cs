using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    private bool isInRange;

    private Text interactUI;

    private void Awake()
    {
        isInRange = false;
        interactUI = GameObject.FindGameObjectWithTag("InteractUI").GetComponent<Text>();
    }

    void Update()
    {
        if (isInRange && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("ouai gros");
            TriggerDialogue();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isInRange = true;
            interactUI.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isInRange = false;
            interactUI.enabled = false;
        }
    }

    void TriggerDialogue()
    {
        Dialogue_Manager.instance.StartDialogue(dialogue);
        Debug.Log("ouai)");
    }
}
