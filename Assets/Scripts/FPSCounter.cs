using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour
{
    public Text FPSDisplay; // Reference to text object used to display FPS
    public float UpdateInterval = 0.0f; // Interval in seconds at which to update the display

    private float timer; // Internal timer to keep track of how long since last update

    // Update is called once per frame
    void Update()
    {
        // Adds the time since the last frame to the timer
        timer += Time.unscaledDeltaTime;

        // If the time passed since the last update has exceeded UpdateInterval
        if (timer > UpdateInterval)
        {
            // Reset the internal time
            timer = 0.0f;

            // Update the text display with the current FPS
            FPSDisplay.text = ((int)(1f / Time.unscaledDeltaTime)).ToString() + " FPS";
        }
    }
}
