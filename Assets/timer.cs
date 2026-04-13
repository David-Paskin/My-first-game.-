using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{

    // Assign your TMP_Text or TextMeshProUGUI component in the Unity Inspector
    public TMP_Text timeText;
    public TMP_Text scoreText; 
    public TMP_Text timeLeft; 
    public GameObject loseScreen;
    public GameObject winScreen;
    private float time = 15.0f;
    public int scoreValue;
    bool isDone=false;

    void Update()
    {

        time -= Time.deltaTime;
        if(double.Parse(scoreText.text)>=10 && !isDone){
            isDone=true;
            winScreen.SetActive(true);
            timeLeft.text=$"Time left: {time:F2}";
        }
        else if (time<0 && double.Parse(scoreText.text)<10 && !isDone){
            isDone=true;
            loseScreen.SetActive(true);
            
        }

        // Convert the float to a string and assign it to the text component
        // You can use string formatting to control the number of decimal places
        timeText.text = time.ToString("F2"); // "F2" formats to two decimal places
    }
}
