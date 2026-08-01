using UnityEngine;



public class cal_distance : MonoBehaviour
{
    public Transform cube1;
    public Transform cube2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Bonjour je suis un cube :-)");
        float distance = Vector3.Distance(cube1.localPosition,cube2.localPosition);
        Debug.Log("cube 1 et cube 2 sont à " + distance + "de distance");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


