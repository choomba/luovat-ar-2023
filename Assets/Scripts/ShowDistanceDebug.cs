using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowDistanceDebug : MonoBehaviour
{
    // text johon et�isyys kirjoitetaan
    public TMP_Text distanceText;

    // et�isyys
    float distance = 1f;

    // gameobjectit joiden v�linen et�isyys
    public Transform from, to;
    
    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(from.position, to.position);

        distanceText.text = distance.ToString();
    }
}
