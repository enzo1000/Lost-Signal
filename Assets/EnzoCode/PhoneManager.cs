using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class PhoneManager : MonoBehaviour
{
    public InputActionReference m_showHideUI;
    public GameObject m_phoneUI;

    private bool m_rotationLock = false;

    //================================================================================================================================
    //================================================================================================================================
    private void Start() {
        // Hide cursor
        Cursor.lockState = CursorLockMode.Locked;
        m_phoneUI.SetActive(false);
    }

    //================================================================================================================================
    //================================================================================================================================
    private void OnEnable() {
        m_showHideUI.action.Enable();
        m_showHideUI.action.performed += OnRightClickPerformed;
    }

    //================================================================================================================================
    //================================================================================================================================
    private void OnRightClickPerformed(InputAction.CallbackContext context) {
        if ( m_showHideUI.action.ReadValue<float>() == 1 ) {
            m_phoneUI.SetActive(!m_phoneUI.activeSelf);
        }

        if ( m_phoneUI.activeSelf ) {
            Cursor.lockState = CursorLockMode.Confined;
            m_rotationLock = true;
        } else {
            m_rotationLock = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    //================================================================================================================================
    //================================================================================================================================
    public bool GetRotationLock() {
        return m_rotationLock;
    }

    //================================================================================================================================
    //================================================================================================================================
    private void OnDestroy() {
        if ( m_showHideUI != null ) {
            m_showHideUI.action.performed -= OnRightClickPerformed;
        }
    }
}
