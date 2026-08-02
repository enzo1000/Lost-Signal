using UnityEngine;
using UnityEngine.InputSystem;

public class Suivi_souris : MonoBehaviour
{

    private PlayerMovement playerMovementScript;
    private InputActionReference lookActionRecuperee;

    private Rigidbody rb;

    [Header("Réglages du Mouvement")]
    public float sensibiliteAllumette = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerMovementScript = GameObject.FindAnyObjectByType<PlayerMovement>();
        rb = GetComponent<Rigidbody>();
        lookActionRecuperee = playerMovementScript.m_lookAction;

        if (rb != null)
        {
            Debug.LogError("rigibody ehfgzgehiouegzhuoi");
        }


    }

    void Update()
    {
        
        if (rb != null && Mouse.current != null)
        {
            
            Vector2 valeurDuLook = lookActionRecuperee.action.ReadValue<Vector2>();

            Vector3 mouvement = new Vector3(0f, valeurDuLook.x, valeurDuLook.y);

            Debug.Log(mouvement.x + " " + mouvement.y);

            rb.MovePosition(rb.position + mouvement * sensibiliteAllumette * Time.fixedDeltaTime);
            rb.MoveRotation(Quaternion.Euler(0f, 0f, 78f));


        }
    }
}
