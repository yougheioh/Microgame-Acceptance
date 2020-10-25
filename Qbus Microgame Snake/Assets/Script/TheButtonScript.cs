﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheButtonScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
