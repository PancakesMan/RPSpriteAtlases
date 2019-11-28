using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Loads a scene based on it's index in the build order
    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    // Exits to application
    public void Quit()
    {
        Application.Quit();
    }
}
