using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour
{
    public Text FPSDisplay;
    public float UpdateInterval = 0.0f;

    private float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.unscaledDeltaTime;
        if (timer > UpdateInterval)
        {
            timer = 0.0f;
            FPSDisplay.text = ((int)(1f / Time.unscaledDeltaTime)).ToString() + " FPS";
        }
    }
}
