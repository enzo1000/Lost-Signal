using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [Header("Input Actions")]
    public InputActionReference m_moveAction;
    public InputActionReference m_lookAction;

    private Vector2 m_turn;
    private Vector3 playerVelocity;
    private CharacterController m_cc = null;

    //================================================================================================================================
    //================================================================================================================================
    void Start() {
        // Hide cursor
        Cursor.lockState = CursorLockMode.Locked;

        m_cc = GetComponent<CharacterController>();
        if ( m_cc == null ) {
            Debug.Log("No Character Controller Attached");
        }
    }

    //================================================================================================================================
    //================================================================================================================================
    private void OnEnable() {
        m_moveAction.action.Enable();
        m_lookAction.action.Enable();
    }

    //================================================================================================================================
    //================================================================================================================================
    void Update() {
        Vector2 input = m_moveAction.action.ReadValue<Vector2>();
        Vector2 mousePos = m_lookAction.action.ReadValue<Vector2>();

        m_turn.x += mousePos.x;
        m_turn.y += mousePos.y;
        transform.rotation = Quaternion.Euler(-m_turn.y, m_turn.x, 0);

        Vector3 move = transform.right * input.x + transform.forward * input.y;
        move.y = 0.0f;  // Move.y != input.y
        move = Vector3.ClampMagnitude(move, 1f);

        // Apply Gravity
        playerVelocity.y += -9.81f * Time.deltaTime;

        // Combine horizontal and vertical movement
        Vector3 finalMove = (move * 5.0f) + (playerVelocity.y * Vector3.up);
        m_cc.Move(finalMove * Time.deltaTime);
    }
}
