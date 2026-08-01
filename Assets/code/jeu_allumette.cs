using UnityEngine;
using UnityEngine.InputSystem;

public class jeu_allumette : MonoBehaviour
{
    private bool isPlayerInZone = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            isPlayerInZone = true;
            Debug.Log("Appuie sur E CHIENNNNNNN" + other.name);
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            isPlayerInZone = false;
            Debug.Log("TIE PARTIT SALE CHIEN !");
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        if (isPlayerInZone && Keyboard.current.eKey.wasPressedThisFrame)
        {
            IlAApuiyercecon();
        }
    }

    void IlAApuiyercecon()
    {
        Debug.Log("bravo ta appuie t trop fort bebou <3");
        

    }
}
