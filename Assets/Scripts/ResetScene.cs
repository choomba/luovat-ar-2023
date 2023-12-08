using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{

    public void ResetARScene()
    {
        // lataa build settingseissä ensimmäisenä oleva scene.
        SceneManager.LoadScene(0);
    }

}
