using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleGameObject : MonoBehaviour
{
    public GameObject objectToToggle1; // primer objeto a habilitar/deshabilitar
    public GameObject objectToToggle2; // segundo objeto a habilitar/deshabilitar
    private Button toggleButton; // el botón que activará/desactivará los objetos
    private bool isObject1Active = true; // estado inicial del primer objeto

    private void Start()
    {
        toggleButton = GetComponent<Button>();

        toggleButton.onClick.AddListener(ToggleObjects);
    }

    public void ToggleObjects()
    {
        if (isObject1Active)
        {
            objectToToggle1.SetActive(false);
            objectToToggle2.SetActive(true);
        }
        else
        {
            objectToToggle1.SetActive(true);
            objectToToggle2.SetActive(false);
        }
        isObject1Active = !isObject1Active;
    }
}
