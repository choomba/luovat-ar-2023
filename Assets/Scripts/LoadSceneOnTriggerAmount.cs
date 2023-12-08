using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnTriggerAmount : MonoBehaviour
{
    [SerializeField]
    int triggerCount = 0;

    public int TriggerLevel = 5;

    public string sceneName;

    private void OnTriggerEnter(Collider other)
    {
        triggerCount++;

        if (triggerCount >= TriggerLevel)
        {
            if (sceneName != "")
            {

                SceneManager.LoadScene(sceneName);
            }
            else
            {
                Debug.LogError("Ei sceneä ladattavaksi", this);
            }
        }
    }

}
