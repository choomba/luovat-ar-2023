using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowDistanceDebug : MonoBehaviour
{
    // text johon etäisyys kirjoitetaan
    public TMP_Text distanceText;

    // etäisyys
    float distance = 1f;

    // gameobjectit joiden välinen etäisyys
    public Transform from, to;
    
    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(from.position, to.position);

        distanceText.text = distance.ToString();
    }
}
