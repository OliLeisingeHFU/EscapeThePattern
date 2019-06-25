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
        if (modelle[i].name == "TopfForm"|| modelle[i].name == "StuhlForm"|| modelle[i].name == "Holo"|| modelle[i].name == "Holo2")
        {
                modelle[i].GetComponent<BoxCollider>().enabled = !modelle[i].GetComponent<BoxCollider>().enabled;
        }
        }
    }
}
