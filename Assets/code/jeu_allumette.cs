using UnityEngine;
using UnityEngine.InputSystem;

public class jeu_allumette : MonoBehaviour
{
    public GameObject Item_hold;
    private bool isPlayerInZone = false;
    private bool JOUE = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "cube_cheminee")
        {
            isPlayerInZone = true;
            Debug.Log("Appuie sur E CHIENNNNNNN" + other.name);
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == "cube_cheminee")
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

    public bool GetJOUEAllumettes()
    {
        return JOUE;
    }

    private GameObject TelephoneCowboy()
    {
       return GetComponent<HeldItemManager>().GetPhoneCowboy();
    }

    void IlAApuiyercecon()
    {
        Debug.Log("bravo ta appuie t trop fort bebou <3 MTN JOUE CHIEN");
        GameObject Phone = TelephoneCowboy();
        Phone = Instantiate(Item_hold);
        JOUE = true;
        Debug.Log("JOUE = " + JOUE);

    }
}
