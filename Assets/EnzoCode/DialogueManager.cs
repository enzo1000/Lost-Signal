using UnityEngine;
using System.Collections.Generic;

public class DialogueManager : MonoBehaviour
{
    public GameObject m_dialogueBox;
    public List<DialogueBox> m_dialogue;

    private DialogueBox     m_currentDialogue;
    private GameFlowManager m_gameFlowManager;

    private void Start() {
        m_gameFlowManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameFlowManager>();
    }

    private void Update() {
        m_dialogueBox.SetActive(false);
        foreach (DialogueBox db in m_dialogue) {
/*            if ( db.m_currentPhase == *//* *//* && db.m_currentGoal == *//* *//* ) {
                m_currentDialogue = db;
                m_dialogueBox.GetComponentInChildren<TMPro.TextContainer>().enabled = true;
            }*/
        }
    }
}
