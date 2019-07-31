using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
     public Dialogue dialogue;
     [SerializeField]
     GameObject ui_Holder;


     void OnTriggerEnter2D(Collider2D collision)
     {
          ui_Holder.SetActive(true);
          TriggerDialogue();
     }

     void OnTriggerExit2D(Collider2D collision)
     {
          ui_Holder.SetActive(false);
     }



     public void TriggerDialogue()
     {
          ui_Holder.SetActive(true);
          FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
     }

}
