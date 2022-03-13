using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float birdSpeed;
    public int maxAngle, minAngle, angle;
    public bool isGameOver = false;
    public Text gameOver;
    public GameObject player;

    private void Awake()
    {
        gameObject.AddComponent<Rigidbody2D>();

    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            // bird movement will start after left click mouse button
            if(isGameOver==false)
            {
                BirdFlapAndJump();
            }
           

        }

        BirdRotation();
    }

    private void BirdRotation()
    {
        if (rb.velocity.y > 0)
        {
            if (angle <= maxAngle)
            {
                angle = angle + 4;
            }

        }
        else if (rb.velocity.y < 0)
        {
            if (angle >= minAngle)
            {
                angle = angle - 4;
            }
        }
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    private void BirdFlapAndJump()
    {
        rb.velocity = Vector2.zero;
        rb.velocity = new Vector2(rb.velocity.x, birdSpeed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="pipe" || collision.gameObject.tag=="Ground")
        {
            Debug.Log("Game Over");
            gameOver.GetComponent<Text>().enabled = true;
            isGameOver = true;
            player.GetComponent<Animator>().enabled = false; 
        }
    }
}
