using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target;  // El objeto a seguir
    public float smoothing = 5f;  // La suavidad de la cámara al seguir el objeto

    Vector3 offset;  // La distancia entre la cámara y el objeto

    void Start()
    {
        // Calcula la distancia inicial entre la cámara y el objeto
        offset = transform.position - target.position;
    }

    void FixedUpdate()
    {
        // Calcula la posición deseada de la cámara
        Vector3 targetCamPos = target.position + offset;

        // Sigue suavemente el objeto con la cámara
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
