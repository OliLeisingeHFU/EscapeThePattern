using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sleepmanager : MonoBehaviour
{
    public GameObject TextBox;
    // Update is called once per frame
    void Start()
    {
        Invoke("timePassed", 1);
    }

    void timePassed()
    {
        StaticVariables.tcount = StaticVariables.tcount + 1;
        if (StaticVariables.tcount == 24)
            StaticVariables.tcount = 0;
        TextBox.GetComponent<Text>().text = "" + StaticVariables.tcount + " Uhr";

        Invoke("timePassed", 1);
    }

    void Update()
    {
        TextBox.GetComponent<Text>().text = "" + StaticVariables.tcount + " Uhr";

        if (Input.GetKeyDown(KeyCode.Space) && StaticVariables.sleeping)
        {
            if (StaticVariables.tcount < 5 || StaticVariables.tcount > 22)
            {
                SceneManager.LoadSceneAsync("Level1Night", LoadSceneMode.Additive);
            }
            else
            {
                StaticVariables.timesWokenUp += 1;
                SceneManager.LoadSceneAsync("Level1", LoadSceneMode.Additive);
            }
        }
    }
}
