using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target;  // El objeto a seguir
    public float smoothing = 5f;  // La suavidad de la c�mara al seguir el objeto

    Vector3 offset;  // La distancia entre la c�mara y el objeto

    void Start()
    {
        // Calcula la distancia inicial entre la c�mara y el objeto
        offset = transform.position - target.position;
    }

    void FixedUpdate()
    {
        // Calcula la posici�n deseada de la c�mara
        Vector3 targetCamPos = target.position + offset;

        // Sigue suavemente el objeto con la c�mara
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
