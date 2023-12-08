using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject uiText;
    public Animator animator;
    public float waitTime;

    IEnumerator uiAnimationTriggerCoroutine;

    // Start is called before the first frame update
    void Start()
    {

        uiAnimationTriggerCoroutine = delayBeforeAnimationTrigger(waitTime);
        StartCoroutine(uiAnimationTriggerCoroutine);
        
    }


    private IEnumerator delayBeforeAnimationTrigger(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            animator.SetTrigger("FadeOut");
        }

    }

}
