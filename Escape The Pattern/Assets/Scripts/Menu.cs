﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void crossPressed()
    {

        SceneManager.LoadSceneAsync("Level1", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("Menu");
    }

}
