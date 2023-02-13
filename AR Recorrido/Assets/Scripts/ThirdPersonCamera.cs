using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target; // El objeto a seguir
    public float distance = 5; // Distancia entre la c�mara y el objeto
    public float height = 2f; // Altura de la c�mara sobre el objeto
    public float rotationDamping = 10f; // Suavidad de la rotaci�n de la c�mara
    public float followSmoothing = 5f; // Suavidad del seguimiento del jugador
    private float currentRotationAngle; // �ngulo actual de rotaci�n de la c�mara
    private float desiredRotationAngle; // �ngulo deseado de rotaci�n de la c�mara
    private Quaternion currentRotation; // Rotaci�n actual de la c�mara
    private Quaternion desiredRotation; // Rotaci�n deseada de la c�mara

    private void LateUpdate()
    {
        // Obtiene la posici�n del jugador
        Vector3 targetPosition = target.position;

        // Calcula la posici�n deseada de la c�mara
        Vector3 desiredPosition = targetPosition - (target.forward * distance) + (Vector3.up * height);

        // Actualiza la posici�n de la c�mara
        transform.position = Vector3.Lerp(transform.position, desiredPosition, followSmoothing * Time.deltaTime);

        // Obtiene la rotaci�n del jugador
        Quaternion targetRotation = target.rotation;

        // Calcula la rotaci�n deseada de la c�mara
        desiredRotationAngle = targetRotation.eulerAngles.y;
        desiredRotation = Quaternion.Euler(0, desiredRotationAngle, 0);

        // Actualiza la rotaci�n de la c�mara suavemente
        currentRotation = transform.rotation;
        currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, desiredRotationAngle, rotationDamping * Time.deltaTime);
        currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);

        transform.rotation = currentRotation;
    }
}
