using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public GameObject TextBox;
    // Start is called before the first frame update
    void Start()
    {
        TextBox.GetComponent<Text>().text = "" + StaticVariables.tcount + " Uhr";
    }

    // Update is called once per frame

}
