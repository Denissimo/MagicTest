using System;
using UnityEngine;

public class ChangeMatherial : MonoBehaviour
{
    private float red = 0.0f;
    public float changeInterval = 2f; // Интервал в секундах
    private float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Renderer targetRenderer;
    void Start()
    {
        targetRenderer = GetComponent<Renderer>();
        
        
        Debug.Log(targetRenderer.material.color.r + ":" + targetRenderer.material.color.g + ":" + targetRenderer.material.color.b);
    }

    // Update is called once per frame
    void Update()
    {
// Уменьшаем таймер каждый кадр
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            Color randomColor = new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
            timer = changeInterval;
            targetRenderer.material.color = randomColor;
        }
        
        
    }
}
