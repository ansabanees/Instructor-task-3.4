using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Vector2 startForce;
    public Rigidbody2D rb;
    public GameObject nextBall;
    // Start is called before the first frame update
    void Start()
    {   // give ball a force to bounce all over the screen
        rb.AddForce(startForce, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    public void Split()
    {   // two smaller balls are spawned when the ball is hit 
        if (nextBall != null)
        {
            GameObject ball1= Instantiate(nextBall, rb.position + Vector2.right / 4f, Quaternion.identity);
            GameObject ball2= Instantiate(nextBall, rb.position + Vector2.left / 4f, Quaternion.identity);

            ball1.GetComponent<BallScript>().startForce = new Vector2(2f, 5f);
            ball2.GetComponent<BallScript>().startForce = new Vector2(-2f, 5f);
        }

        Destroy(gameObject);
    }
}
