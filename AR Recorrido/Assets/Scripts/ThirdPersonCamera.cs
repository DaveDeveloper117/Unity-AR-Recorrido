using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target; // El objeto a seguir
    public float distance = 5; // Distancia entre la cámara y el objeto
    public float height = 2f; // Altura de la cámara sobre el objeto
    public float rotationDamping = 10f; // Suavidad de la rotación de la cámara
    public float followSmoothing = 5f; // Suavidad del seguimiento del jugador
    private float currentRotationAngle; // Ángulo actual de rotación de la cámara
    private float desiredRotationAngle; // Ángulo deseado de rotación de la cámara
    private Quaternion currentRotation; // Rotación actual de la cámara
    private Quaternion desiredRotation; // Rotación deseada de la cámara

    private void LateUpdate()
    {
        // Obtiene la posición del jugador
        Vector3 targetPosition = target.position;

        // Calcula la posición deseada de la cámara
        Vector3 desiredPosition = targetPosition - (target.forward * distance) + (Vector3.up * height);

        // Actualiza la posición de la cámara
        transform.position = Vector3.Lerp(transform.position, desiredPosition, followSmoothing * Time.deltaTime);

        // Obtiene la rotación del jugador
        Quaternion targetRotation = target.rotation;

        // Calcula la rotación deseada de la cámara
        desiredRotationAngle = targetRotation.eulerAngles.y;
        desiredRotation = Quaternion.Euler(0, desiredRotationAngle, 0);

        // Actualiza la rotación de la cámara suavemente
        currentRotation = transform.rotation;
        currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, desiredRotationAngle, rotationDamping * Time.deltaTime);
        currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);

        transform.rotation = currentRotation;
    }
}
