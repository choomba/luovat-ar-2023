using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayDeActivate : MonoBehaviour
{
    IEnumerator coroutine;

    public void SetGameObjectDeactive(float waitSeconds)
    {
        // annetaan coroutinelle parametriksi odotusaika
        coroutine = delayBeforeDeactivate(waitSeconds);
        StartCoroutine(coroutine);
    }
    
    private IEnumerator delayBeforeDeactivate(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            gameObject.SetActive(false);
        }
    }


}
