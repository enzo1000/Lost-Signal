using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem;

public class jeu_allumette : MonoBehaviour
{
    public GameObject Item_hold;

    public GameObject holder_alu;
    public GameObject Allumette;
    private GameObject instanceobjet;

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

private GameObject Holdermyboy()
{
    return GetComponent<HeldItemManager>().GetHolderCowboy();
}

void IlAApuiyercecon()
{
    Debug.Log("bravo ta appuie t trop fort bebou <3 MTN JOUE CHIEN");

    GameObject Phone = TelephoneCowboy();
    GameObject holder = Holdermyboy();
    //Phone.SetActive(false);

    //GameObject boite_alu = Instantiate(Item_hold);
    //boite_alu.transform.parent = holder.transform;
    //boite_alu.transform.localPosition = Vector3.zero;

    //instanceobjet = Instantiate(Allumette);
    //instanceobjet.transform.parent = holder_alu.transform;
    //instanceobjet.transform.localPosition = Vector3.zero;
    
    //holder_alu.GetComponent<MeshRenderer>().enabled = false;

    //Debug.Log(instanceobjet.GetComponent<Rigidbody>());

    //instanceobjet.AddComponent<Suivi_souris>();

    //JOUE = true;
    //Debug.Log("JOUE = " + JOUE);



}
}