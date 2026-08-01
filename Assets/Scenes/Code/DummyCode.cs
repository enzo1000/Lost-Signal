using UnityEngine;

public class DummyCode : MonoBehaviour
{
    public string m_name;

    [SerializeField] private string m_name2;
    private bool m_isRunning = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("toto");
        m_isRunning = true;

        GetComponent<DummyCode>();

        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("titi");
    }
}
