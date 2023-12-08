using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ARButton : MonoBehaviour
{
    // UnityEvent-tyyppinen julkinen muuttuja, joka voi sis�lt�� useita tapahtumia (events)
    public UnityEvent unityEvent = null;

    // T�m� metodi kutsutaan, kun k�ytt�j� painaa hiiren vasenta nappia (tai kosketusn�ytt��)
    private void OnMouseDown()
    {
        // Tarkistetaan, ett� unityEvent-muuttuja ei ole null, ennen kuin kutsutaan sen Invoke-metodia
        // T�m� suojaa sovellusta mahdollisilta virheilt�, jos tapahtumaa ei ole liitetty Unity-editorissa
        //unityEvent?.Invoke();
    }

    private void OnMouseUp()
    {
        // Tarkistetaan, ett� unityEvent-muuttuja ei ole null, ennen kuin kutsutaan sen Invoke-metodia
        // T�m� suojaa sovellusta mahdollisilta virheilt�, jos tapahtumaa ei ole liitetty Unity-editorissa
        unityEvent?.Invoke();

    }
}
