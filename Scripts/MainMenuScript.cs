using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public float scene = 0;
    public void SceneLoader(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
