using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrillenActivator : MonoBehaviour
{
    private static GameObject[] modelle = GameObject.FindGameObjectsWithTag("Form");
    // Start is called before the first frame update
    public static void Formen()
    {
        for (int i = 0; i < modelle.Length; i++)
        {
            modelle[i].GetComponent<MeshRenderer>().enabled = !modelle[i].GetComponent<MeshRenderer>().enabled;
        }
    }
}
