using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float speed = 5f;
    public float runSpeed = 10f;
    float targetMovingSpeed;
    public bool canRun = true;
    public bool isRunning;
    public KeyCode runnihgKey = KeyCode.LeftShift;
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    void Awake(){
        playerRigidbody = this.GetComponent<Rigidbody>();

    }


    void FixedUpdate(){
        if(canRun &&  Input.GetKey(runnihgKey))
        {
            isRunning=true;
        }
        else
        {
            isRunning=false;
        }

        if(isRunning)
        {
            targetMovingSpeed = runSpeed;
        }
        else
        {
            targetMovingSpeed = speed;
        }

        playerRigidbody.velocity = transform.rotation * new Vector3(Input.GetAxis("Horizontal"), playerRigidbody.velocity.y, Input.GetAxis("Vertical") * targetMovingSpeed);

        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * (100f * Time.deltaTime), Space.Self);
    }


}
