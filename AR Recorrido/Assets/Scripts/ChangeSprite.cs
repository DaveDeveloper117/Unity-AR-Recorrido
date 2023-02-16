using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    public Sprite[] sprites;  // Array de sprites a mostrar
    public float interval = 1f;  // Intervalo de tiempo para cambiar el sprite

    private SpriteRenderer spriteRenderer;
    private int currentIndex = 0;  // Índice del sprite actual
    private float timer = 0f;  // Temporizador para cambiar el sprite

    void Start()
    {
        // Obtener el componente SpriteRenderer
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Establecer el primer sprite del array
        spriteRenderer.sprite = sprites[currentIndex];
    }

    void Update()
    {
        // Incrementar el temporizador
        timer += Time.deltaTime;

        // Si el tiempo de espera ha transcurrido, cambiar el sprite
        if (timer >= interval)
        {
            // Restablecer el temporizador
            timer = 0f;

            // Incrementar el índice del sprite actual
            currentIndex++;

            // Si hemos llegado al final del array, volver al principio
            if (currentIndex >= sprites.Length)
            {
                currentIndex = 0;
            }

            // Cambiar el sprite del componente SpriteRenderer
            spriteRenderer.sprite = sprites[currentIndex];
        }
    }
}
