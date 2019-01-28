using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour {

    enum scenes { Start, Main, End };

    public void LoadStartScene()
    {
        SceneManager.LoadScene((init)scenes.Start);
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene((init)scenes.Main)
    }

    public void LoadEndScene()
    {
        SceneManager.LoadScene((init)scenes.End)
    }

    public void QuitGame ()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

}
