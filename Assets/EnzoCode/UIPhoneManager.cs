using UnityEngine;

public class UIPhoneManager : MonoBehaviour
{
    public GameObject m_mainMenuFrame;
    public GameObject m_mapMenuFrame;
    public GameObject m_smsMenuFrame;

    public GameObject m_phoneSignal;

    //================================================================================================================================
    //================================================================================================================================
    public void OpenTelephone() {
        m_mainMenuFrame.SetActive(true);
        //m_mapMenuFrame.SetActive(false);
        m_smsMenuFrame.SetActive(false);
    }

    //================================================================================================================================
    //================================================================================================================================
    public void OnClickShowMap() {
        m_mainMenuFrame.SetActive(false);
        m_mapMenuFrame.SetActive(true);
    }

    //================================================================================================================================
    //================================================================================================================================
    public void OnClickShowSms() {
        m_mainMenuFrame.SetActive(false);
        m_smsMenuFrame.SetActive(true);
    }
}
