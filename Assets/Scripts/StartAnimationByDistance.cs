using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimationByDistance : MonoBehaviour
{

    public Transform arTransform;

    public float startDistance = 0.3f;

    float currentDistance;
    Animator animator;
    public string AnimationBoolString = "";

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        currentDistance = Vector3.Distance(transform.position, arTransform.position);

        if (currentDistance < startDistance)
        {
            animator.SetBool(AnimationBoolString, true);
        }
        else
        {
            animator.SetBool(AnimationBoolString, false);
        }


    }
}
