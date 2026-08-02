using UnityEngine;

[CreateAssetMenu(fileName = "DialogueBox", menuName = "Scriptable Objects/DialogueBox")]
public class DialogueBox : ScriptableObject {
    public GameFlowManager.GamePhase m_currentPhase;
    public GameFlowManager.GameGoal m_currentGoal;
    public float   m_showTime;
    public float   m_hideTime;
    public string  m_fullConnexionTexte;
    public string  m_medConnexionTexte;
    public string  m_lowConnexionTexte;
}
