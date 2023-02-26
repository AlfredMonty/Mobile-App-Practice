using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float deadZone = -45f; 

    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed * Time.deltaTime);

        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject); 
        }
    }
}
