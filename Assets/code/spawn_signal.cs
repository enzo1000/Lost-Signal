using UnityEngine;
using System.Collections.Generic;
using System;

public class spawn_signal : MonoBehaviour
{
    public List<GameObject> m_gameObjectList = new List<GameObject>();

    [Header("Nombre d'objets à désactiver")]
    public int nombreObjetsASupprimer = 0;

    private MeshRenderer mesh;

    void Start()
    {
         nombreObjetsASupprimer = Mathf.Min(nombreObjetsASupprimer, m_gameObjectList.Count);

        List<int> indicesDisponibles = new List<int>();

        // Remplit la liste des indices
        for (int i = 0; i < m_gameObjectList.Count; i++)
        {
            indicesDisponibles.Add(i);
        }

        // Désactive les objets sans répétition
        for (int i = 0; i < nombreObjetsASupprimer; i++)
        {
            float random = UnityEngine.Random.Range(0, indicesDisponibles.Count);
            int rrr = Mathf.RoundToInt(random);
            int index = indicesDisponibles[rrr];
            GetOut(index);

            // Retire l'index pour éviter de le reprendre
            indicesDisponibles.RemoveAt(rrr);
        }

    }

    void GetOut(int valeur_tableau)
    {
        mesh = m_gameObjectList[valeur_tableau].GetComponent<MeshRenderer>();
        mesh.enabled = false;
    }
}