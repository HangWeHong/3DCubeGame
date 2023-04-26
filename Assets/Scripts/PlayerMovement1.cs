using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{   public Rigidbody RB;
    public float ForwardSpeed = 20f;
    public float SidewaysSpeed = 500f;
    public float JumpingSpeed = 3f;
    public Transform player;
    public bool isjumped = false;
    // Start is called before the first frame update
    void Start()
    { 
        RB.useGravity =true;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {   RB.AddForce(0,0,ForwardSpeed);
 
        if (Input.GetKey("d"))
        {
            RB.AddForce(SidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }//float horizontal = Input.GetAxis("Horizontal");
        //RB.velocity = new Vector3(horizontal * SidewaysSpeed * Time.deltaTime, RB.velocity.y, ForwardSpeed);
        if (Input.GetKey("a"))
        {
            RB.AddForce(-SidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        { 
            if (RB.position .y <= 1 && RB.position.x >=-7.8 && RB.position.x <=7.8)
            {
                RB.AddForce(0, JumpingSpeed * Time.deltaTime, 0);
            }               
        }
        
        if (player.position.y<-1f) //or RB.position.y<-1
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
      
      
    }
}

