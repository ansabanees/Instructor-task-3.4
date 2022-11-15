using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 4.0f;
    public Rigidbody2D rb;
    private float horizontalInput = 0;
    

       
    // Update is called once per frame
    void Update()
    {   // player input to move sideways
        horizontalInput = Input.GetAxisRaw("Horizontal") * speed;
       
    }
    private void FixedUpdate()
    {   // movement of the player
        rb.MovePosition(rb.position + new Vector2(horizontalInput * Time.fixedDeltaTime, 0f));
    }


    void OnCollisionEnter2D(Collision2D col)
    {   // if player collides with the ball, game over!
        if (col.collider.tag == "Ball")
        {
            Debug.Log("GAME OVER");
            SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
        }
    }
}
