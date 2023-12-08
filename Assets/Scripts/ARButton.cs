using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ARButton : MonoBehaviour
{
    // UnityEvent-tyyppinen julkinen muuttuja, joka voi sisältää useita tapahtumia (events)
    public UnityEvent unityEvent = null;

    // Tämä metodi kutsutaan, kun käyttäjä painaa hiiren vasenta nappia (tai kosketusnäyttöä)
    private void OnMouseDown()
    {
        // Tarkistetaan, että unityEvent-muuttuja ei ole null, ennen kuin kutsutaan sen Invoke-metodia
        // Tämä suojaa sovellusta mahdollisilta virheiltä, jos tapahtumaa ei ole liitetty Unity-editorissa
        //unityEvent?.Invoke();
    }

    private void OnMouseUp()
    {
        // Tarkistetaan, että unityEvent-muuttuja ei ole null, ennen kuin kutsutaan sen Invoke-metodia
        // Tämä suojaa sovellusta mahdollisilta virheiltä, jos tapahtumaa ei ole liitetty Unity-editorissa
        unityEvent?.Invoke();

    }
}
