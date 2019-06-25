using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public static AudioSource levelsucceed;
    public AudioSource sound;
    static public LevelLoader instance;

    void Awake()
    {
        instance = this;
        levelsucceed = sound;
    }

    public static void LoadNextLevel()
    {
        Level1script.Resetti();
        StaticVariables.i++;
        levelsucceed.Play();
        instance.StartCoroutine(LoadSceneAsyncAndWaitForAudio());
    }

    static IEnumerator LoadSceneAsyncAndWaitForAudio()
    {
        AsyncOperation asyncLoadOperation = SceneManager.LoadSceneAsync(StaticVariables.level[StaticVariables.i], LoadSceneMode.Single);
        asyncLoadOperation.allowSceneActivation = false;

        yield return new WaitForSeconds(3);

        Debug.Log("Loading next level");
        asyncLoadOperation.allowSceneActivation = true;
    }
}
