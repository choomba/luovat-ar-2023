using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadARScene : MonoBehaviour
{

    [SerializeField]
    string scene;

    public void LoadNextARScene()
    {
        LoadNextARScene(scene);
    }

    public void LoadNextARScene(string sceneName)
    {
        // lataa annettu scene
        SceneManager.LoadScene(sceneName);
    }

}
