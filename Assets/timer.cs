using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{

    // Assign your TMP_Text or TextMeshProUGUI component in the Unity Inspector
    public TMP_Text timeText;
    public TMP_Text scoreText; 
    public GameObject loseScreen;
    public GameObject winScreen;
    private float time = 15.0f;
    public int scoreValue;

    void Update()
    {

            time -= Time.deltaTime;
            if (time<0){
                if (int.Parse(scoreText.text)<10){
                   loseScreen.SetActive(true);
                }
                else
                {
                    winScreen.SetActive(true);
                }
            }

        // Convert the float to a string and assign it to the text component
        // You can use string formatting to control the number of decimal places
        timeText.text = time.ToString("F2"); // "F2" formats to two decimal places
    }
}
