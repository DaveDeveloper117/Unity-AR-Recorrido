using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChanger : MonoBehaviour
{
    public Sprite[] images;
    public float timeInterval = 1f;

    private Image image;
    private int currentIndex = 0;
    private float timer = 0f;

    private void Start()
    {
        image = GetComponent<Image>();
        image.sprite = images[0];
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeInterval)
        {
            timer = 0f;
            currentIndex = (currentIndex + 1) % images.Length;
            image.sprite = images[currentIndex];
        }
    }
}
