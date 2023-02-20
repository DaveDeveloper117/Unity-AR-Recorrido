using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    public GameObject panel;

    private Button button;

    public void Start()
    {
        button = GetComponent<Button>();

        // Agregar un listener al botón para detectar el click
        button.onClick.AddListener(TogglePanel);
    }

    public void TogglePanel()
    {
        // Obtener el estado actual del panel
        bool isActive = panel.activeSelf;

        // Cambiar el estado del panel
        panel.SetActive(!isActive);
    }
}
