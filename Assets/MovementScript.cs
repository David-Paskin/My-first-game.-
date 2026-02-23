using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
// assigns the speed to five. 
public float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
      // gets user input of left and right keys
      float moveX= Input.GetAxisRaw("Horizontal"); 
      // gets user input of up and down keys
      float moveY= Input.GetAxisRaw("Vertical");  
      //its taking the move X and move Y and mutplying it by speed and time. 
      transform.Translate(new Vector2(moveX,moveY)*moveSpeed*Time.deltaTime);
    }
}
