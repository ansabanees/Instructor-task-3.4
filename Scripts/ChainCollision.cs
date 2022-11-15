using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {  // making the collision happen when chain hits the ball
        ChainScript.isFired = false;

        if (col.tag == "Ball")
        {
            col.GetComponent<BallScript>().Split();
        }
    }
}
