using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{

    public void ResetARScene()
    {
        // lataa build settingseiss� ensimm�isen� oleva scene.
        SceneManager.LoadScene(0);
    }

}
