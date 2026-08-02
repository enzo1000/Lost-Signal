using UnityEngine;

public class cal_distance : MonoBehaviour
{
    private GameObject m_playerPrefab;
    private float m_distanceMidSignal;
    private float m_distanceFullSignal;
    private bool m_isPlayerInRange = false;

    private GameObject m_connexionGOLow;
    private GameObject m_connexionGOMed;
    private GameObject m_connexionGOAll;

    //================================================================================================================================
    //================================================================================================================================
    private void Start() {
        m_distanceMidSignal = Mathf.Abs(GetComponent<BoxCollider>().bounds.max.x / 2);
        m_distanceFullSignal = Mathf.Abs(GetComponent<BoxCollider>().bounds.max.x / 4);

        m_playerPrefab = GameObject.FindGameObjectWithTag("Player").gameObject;

        m_connexionGOLow = m_playerPrefab.transform.Find("PlayerUI/ConnexionPlaceHolder/ConnexionLow").gameObject;
        m_connexionGOMed = m_playerPrefab.transform.Find("PlayerUI/ConnexionPlaceHolder/ConnexionMid").gameObject;
        m_connexionGOAll = m_playerPrefab.transform.Find("PlayerUI/ConnexionPlaceHolder/ConnexionFull").gameObject;
    }

    //================================================================================================================================
    //================================================================================================================================
    private void OnTriggerEnter(Collider other) {
        if ( other.gameObject.tag == "Player" ) {
            m_isPlayerInRange = true;
        }
    }

    //================================================================================================================================
    //================================================================================================================================
    private void OnTriggerExit(Collider other) {
        if ( other.gameObject.tag == "Player" ) {
            m_isPlayerInRange = false;
        }
    }

    //================================================================================================================================
    //================================================================================================================================
    void Update() {
        if ( m_isPlayerInRange ) {
            float dist = Vector3.Distance(transform.position, m_playerPrefab.transform.position);
            if ( dist < m_distanceMidSignal ) {
                m_playerPrefab.GetComponentInChildren<DialogueManager>().SetConnexionState(DialogueManager.ConnexionState.Med);
                m_connexionGOLow.SetActive(false);
                m_connexionGOMed.SetActive(true);
                if ( dist < m_distanceFullSignal ) {
                    m_playerPrefab.GetComponentInChildren<DialogueManager>().SetConnexionState(DialogueManager.ConnexionState.Full);
                    m_connexionGOMed.SetActive(false);
                    m_connexionGOAll.SetActive(true);
                }
            }
        }else {
            m_playerPrefab.GetComponentInChildren<DialogueManager>().SetConnexionState(DialogueManager.ConnexionState.Low);
            m_connexionGOLow.SetActive(true);
        }
    }
}


