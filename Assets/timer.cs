using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{

    // Assign your TMP_Text or TextMeshProUGUI component in the Unity Inspector
    public TMP_Text scoreText; 
    private float time = 10.0f;
    public int scoreValue;

    void Update()
    {
        // Update the float value (example: a timer counting down)
        if (scoreValue > 0)
        {
            time -= Time.deltaTime;
        }

        // Convert the float to a string and assign it to the text component
        // You can use string formatting to control the number of decimal places
        scoreText.text = time.ToString("F2"); // "F2" formats to two decimal places
    }
}
