using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class collectableScript : MonoBehaviour
{
        public TMP_Text text;
        private int score=0;

private void OnTriggerEnter2D(Collider2D other){
    score++;
    text.text=score.ToString();
    //if(other.CompareTag("Player")){ 

  //  }
}

}
