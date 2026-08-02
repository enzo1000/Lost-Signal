using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public GameObject           m_dialogueBox;
    public List<DialogueBox>    m_dialogue;

    private GameFlowManager     m_gameFlowManager = null;
    private float               m_textTimer = 0;
    private DialogueBox         m_currentDialogue = null;

    public enum ConnexionState {
        Low,
        Med,
        Full
    }

    private ConnexionState m_connexionState = ConnexionState.Low;
    private ConnexionState m_currentTexteConnexionState = ConnexionState.Low;

    //================================================================================================================================
    //================================================================================================================================
    private void Start() {
        m_gameFlowManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameFlowManager>();
        if ( m_gameFlowManager == null ) { Debug.Log( "GameFlowManager not found" ); }
    }

    //================================================================================================================================
    //================================================================================================================================
    private void Update() {
        if ( m_currentDialogue == null ) {  // If we don't have dialogues
            AssignNewDialog();              // new dialogue
        } else if ( m_gameFlowManager.GetCurrentPhase() != m_currentDialogue.m_currentPhase 
            || m_gameFlowManager.GetCurrentGoal() != m_currentDialogue.m_currentGoal 
            || m_connexionState != m_currentTexteConnexionState ) { // If the states of the game as changed

            AssignNewDialog();              // new dialogue

        } else if ( m_currentDialogue != null ) {   // Incr timer
            if ( m_textTimer < m_currentDialogue.m_showTime ) {
                m_dialogueBox.SetActive(true);
                m_textTimer += Time.deltaTime;
            } 
            else if ( m_textTimer < m_currentDialogue.m_showTime + m_currentDialogue.m_hideTime ) { // Incr timer but hide dialogue box
                m_dialogueBox.SetActive(false);
                m_textTimer += Time.deltaTime;
            }
            else {  // m_textTimer > m_showTime + m_hideTime
                m_textTimer = 0.0f;
            }
        }
    }

    //================================================================================================================================
    //================================================================================================================================
    private void AssignNewDialog() {
        foreach ( DialogueBox db in m_dialogue ) {  // research phase
            if ( db.m_currentPhase == m_gameFlowManager.GetCurrentPhase() && db.m_currentGoal == m_gameFlowManager.GetCurrentGoal() ) {
                m_dialogueBox.SetActive(true);
                m_currentDialogue = db;
                switch ( m_connexionState ) {
                    case ConnexionState.Low:
                        m_dialogueBox.GetComponentInChildren<TMP_Text>().text = db.m_lowConnexionTexte;
                        m_currentTexteConnexionState = ConnexionState.Low;
                        break;
                    case ConnexionState.Med:
                        m_dialogueBox.GetComponentInChildren<TMP_Text>().text = db.m_medConnexionTexte;
                        m_currentTexteConnexionState = ConnexionState.Med;
                        break;
                    case ConnexionState.Full:
                        m_dialogueBox.GetComponentInChildren<TMP_Text>().text = db.m_fullConnexionTexte;
                        m_currentTexteConnexionState = ConnexionState.Full;
                        break;
                }
            }
        }
    }

    public void SetConnexionState(ConnexionState _other) {
        m_connexionState = _other;
    }
}
