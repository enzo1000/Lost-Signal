using UnityEngine;

public class cal_distance : MonoBehaviour
{
    private GameObject m_playerPrefab;
    private float m_distanceMidSignal;
    private float m_distanceFullSignal;
    private bool m_isPlayerInRange = false;

    //================================================================================================================================
    //================================================================================================================================
    private void Start() {
        m_distanceMidSignal = Mathf.Abs(GetComponent<BoxCollider>().bounds.max.x / 2);
        m_distanceFullSignal = Mathf.Abs(GetComponent<BoxCollider>().bounds.max.x / 4);
    }

    //================================================================================================================================
    //================================================================================================================================
    private void OnTriggerEnter(Collider other) {
        if ( other.gameObject.tag == "Player" ) {
            m_isPlayerInRange = true;
            m_playerPrefab = other.gameObject;
        }
    }

    //================================================================================================================================
    //================================================================================================================================
    private void OnTriggerExit(Collider other) {
        if ( other.gameObject.tag == "Player" ) {
            m_isPlayerInRange = false;
            m_playerPrefab = null;
        }
    }

    //================================================================================================================================
    //================================================================================================================================
    void Update() {
        if ( m_isPlayerInRange ) {
            float dist = Vector3.Distance(transform.position, m_playerPrefab.transform.position);
        }
    }
}


