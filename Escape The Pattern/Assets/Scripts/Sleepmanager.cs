using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sleepmanager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
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
