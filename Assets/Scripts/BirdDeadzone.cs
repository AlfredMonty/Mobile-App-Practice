using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Deadzone for bird Method 2 
//Deadzone Method 1 in BirdScript is better for single instance of death.
//This deadzone can be applied to other objects for potential hazards. 

public class BirdDeadzone : MonoBehaviour
{
    public Logic logic;

    public BirdScript birdScript; 

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    //Bird death. 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            Debug.Log("Player Died.");
            logic.GameOver();
            birdScript.birdAlive = false; 
        }
    }
}
