using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpHeight = 0;
    public Logic logic;
    public bool birdAlive = true; 

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.name = "Greg"; 
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdAlive) {
            rb.velocity = Vector2.up * jumpHeight;
        }

        //Deadzone for bird Method 1
        //if (transform.position.y > 16 || transform.position.y < -16)
        //{
        //    logic.GameOver();
        //    birdAlive = false;
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdAlive = false;
    }
}
