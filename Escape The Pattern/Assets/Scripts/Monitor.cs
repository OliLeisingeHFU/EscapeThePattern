using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monitor : MonoBehaviour
{
    public Material Material1;
    public Material Material2;
    public Material Material3;
    public Material Material4;
    //in the editor this is what you would set as the object you wan't to change
    public GameObject Monitor1;

    void Start()
    {
        switch(StaticVariables.timesWokenUp)
        {
            case 1:
                Monitor1.GetComponent<MeshRenderer>().material = Material1;
                break;
            case 2:
                Monitor1.GetComponent<MeshRenderer>().material = Material2;
                break;
            case 3:
                Monitor1.GetComponent<MeshRenderer>().material = Material3;
                break;
            case 4:
                Monitor1.GetComponent<MeshRenderer>().material = Material4;
                break;
            default:
                Monitor1.GetComponent<MeshRenderer>().material = Material1;
                StaticVariables.timesWokenUp = 1;
                break;

        }
    }
}
