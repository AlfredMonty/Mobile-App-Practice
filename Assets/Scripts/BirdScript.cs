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
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        //Bird Controls.
        if ((Input.GetKeyDown(KeyCode.Space) && birdAlive) || (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began && birdAlive)) {
            rb.velocity = Vector2.up * jumpHeight;
            logic.scoreAudio.clip = logic.jump;
            GetComponent<AudioSource>().PlayOneShot(logic.jump, 1);
        }
        if (Input.GetKeyDown(KeyCode.Delete) && !birdAlive)
        {
            PlayerPrefs.DeleteAll();
        }
        //End app. 
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //For Android; Take out for Windows build.  
            if (Application.platform == RuntimePlatform.Android)
            {
                AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
                activity.Call<bool>("moveTaskToBack", true);
            }
            else
            {
                logic.OnApplicationQuit();
            }
            logic.OnApplicationQuit();
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
