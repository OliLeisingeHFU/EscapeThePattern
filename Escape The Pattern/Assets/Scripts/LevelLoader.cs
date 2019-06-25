using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    private static int i = -1;
    private static string[] level = { "Tutorial", "Level1", "Level2", "End"};
    public static void LoadNextLevel()
    {     
        i++;
        SceneManager.LoadSceneAsync(level[i], LoadSceneMode.Additive);
    }
}
