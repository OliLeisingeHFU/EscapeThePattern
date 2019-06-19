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
       Invoke("timePassed", 1);
        SceneManager.UnloadSceneAsync("Level1");
        SceneManager.UnloadSceneAsync("Level1Night");

 
    }

    // Update is called once per frame
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
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(StaticVariables.tcount < 5 || StaticVariables.tcount > 22)
            {
                SceneManager.LoadSceneAsync("Level1Night", LoadSceneMode.Additive);
            }else
            {
                StaticVariables.timesWokenUp += 1;
                SceneManager.LoadSceneAsync("Level1", LoadSceneMode.Additive);
            }
        }
    }
}
