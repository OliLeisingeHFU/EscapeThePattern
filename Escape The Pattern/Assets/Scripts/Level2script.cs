using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2script : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(StaticVariables.code == 0 && Input.GetKeyDown(KeyCode.Alpha1))
        {
            StaticVariables.code++;
        }
        if (StaticVariables.code == 1 && Input.GetKeyDown(KeyCode.Alpha6))
        {
            StaticVariables.code++;
        }
        if (StaticVariables.code == 2 && Input.GetKeyDown(KeyCode.Alpha8))
        {
            StaticVariables.code++;
        }
        if (StaticVariables.code == 3 && Input.GetKeyDown(KeyCode.Alpha9))
        {
            LevelLoader.LoadNextLevel();
        }else
        {

        }
    }
}
