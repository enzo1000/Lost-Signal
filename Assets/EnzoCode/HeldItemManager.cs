using UnityEngine;

public class HeldItemManager : MonoBehaviour
{
    public GameObject m_itemToHold;
    public GameObject m_holder;

    private GameObject m_instantiatedGameObject;

    private void Start() {
        m_instantiatedGameObject = Instantiate(m_itemToHold);
        m_instantiatedGameObject.transform.parent = transform.parent;
        m_holder.GetComponent<MeshRenderer>().enabled = false;
    }

    private void Update() {
        m_instantiatedGameObject.transform.localPosition = m_holder.transform.position;
    }
}
