using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sleepmanager : MonoBehaviour
{
    public GameObject TextBox;
    static public Sleepmanager instance;
    private static AsyncOperation asyncLoadOperation;
    // Update is called once per frame
    void Start()
    {
        Invoke("timePassed", 1);
    }

    void Awake()
    {
        instance = this;
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            instance.StartCoroutine(sleepydeepy());
        }
    }

    static IEnumerator sleepydeepy()
    {
        Debug.Log("Squeek");
        if (StaticVariables.tcount < 5 || StaticVariables.tcount > 22)
        {
            asyncLoadOperation = SceneManager.LoadSceneAsync("Level1Night", LoadSceneMode.Single);
            asyncLoadOperation.allowSceneActivation = false;

        }else
        {
            StaticVariables.timesWokenUp += 1;
            asyncLoadOperation = SceneManager.LoadSceneAsync("Level1", LoadSceneMode.Single);
            asyncLoadOperation.allowSceneActivation = false;
        }

    yield return new WaitForSeconds(1);

    Debug.Log("Loading next level");
    asyncLoadOperation.allowSceneActivation = true;
    }
                
}
