using System;
using TMPro;
using UnityEngine;

public class ShowTimer : MonoBehaviour
{
    private TextMeshProUGUI textTImer;
    float time;
    private void Awake()
    {
        textTImer = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        this.time += Time.deltaTime;
        int time = Mathf.FloorToInt(this.time);
        DisplayTime(time);
    }
    private void DisplayTime(int floatTime)
    {
        float minutes = Mathf.FloorToInt(floatTime / 60);
        float seconds = Mathf.FloorToInt(floatTime % 60);
        textTImer.text = string.Format("{0:00}:{1:00}",minutes, seconds);
    }
}
