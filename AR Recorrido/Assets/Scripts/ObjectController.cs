using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectController : MonoBehaviour
{
    public GameObject[] objectsActive; // Array de objetos activos
    public GameObject[] objectsInactive; // Array de objetos inactivos


    private bool isActive = true; // Estado de los objetos activos


    public void ToggleObjects()
    {
        isActive = !isActive;

        // Habilitar/deshabilitar objetos activos
        foreach (GameObject obj in objectsActive)
        {
            obj.SetActive(!isActive);
        }

        // Habilitar/deshabilitar objetos inactivos
        foreach (GameObject obj in objectsInactive)
        {
            obj.SetActive(isActive);
        }
    }
}
