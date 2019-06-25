using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject Canvas;

    // Start is called before the first frame update
    public void crossPressed()
    {
        LevelLoader.LoadNextLevel();
        Canvas.gameObject.SetActive(false);
    }

}
