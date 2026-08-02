using UnityEngine;
using UnityEngine.InputSystem;

public class lampe_telephone : MonoBehaviour
{
    private GameObject SPOT;

    private GameObject TelephoneCowboy()
    {
        HeldItemManager manager = GetComponent<HeldItemManager>();
        if (manager != null)
        {
            return GetComponent<HeldItemManager>().GetPhoneCowboy();
        }
        return null;
    }

    void toogle_lampe()
    {

            Debug.Log("bravo ta appuie t trop fort bebou <3 MTN EMBRASSE MOI CHIEN");
            bool nouvelEtat = !SPOT.activeSelf;
            SPOT.SetActive(nouvelEtat);
            Debug.Log(SPOT);
      

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject Phone = TelephoneCowboy();
        Transform LALUMIERE = Phone.transform.Find("Spot Light");
        SPOT = LALUMIERE.gameObject;
        Debug.Log(Phone + " c le telephone");
        Debug.Log("oskour");
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            toogle_lampe();
        }
    }


}
