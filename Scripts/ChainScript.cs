using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainScript : MonoBehaviour
{
    public Transform player;
    public static bool isFired;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        isFired = false;
    }

    // Update is called once per frame
    void Update()
    {   // chain is fired when spacebar is hit
        if (Input.GetButtonDown("Jump"))
        {
            isFired = true;
        }
        // to gradully increase the size of the chain
        if (isFired)
        {
            transform.localScale = transform.localScale + Vector3.up * speed * Time.deltaTime;
        }
        else
        {
            transform.position = player.position;
            transform.localScale = new Vector3(1f, 0f, 1f);
        }
    }
}
