using UnityEngine;

public class HeldItemManager : MonoBehaviour
{
    public GameObject m_itemToHold;
    public GameObject m_holder;

    private GameObject m_instantiatedGameObject;

    //================================================================================================================================
    //================================================================================================================================
    private void Start() {
        m_instantiatedGameObject = Instantiate(m_itemToHold);
        m_instantiatedGameObject.transform.parent = m_holder.transform;     // Reparenting
        m_instantiatedGameObject.transform.localPosition = Vector3.zero;    // Init current position
        m_holder.GetComponent<MeshRenderer>().enabled = false;              // Hide holder
    }

    public GameObject GetPhoneCowboy()
    {
        return m_instantiatedGameObject;
    }

    public GameObject GetHolderCowboy()
    {
        return m_holder;
    }
}
