using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public float RotatePerSecond = 1f;
    public Vector3 RotateDirectionVector = Vector3.up;



    // Update is called once per frame
    void Update()
    {

        gameObject.transform.Rotate(RotateDirectionVector, RotatePerSecond * Time.deltaTime);
    }
}
