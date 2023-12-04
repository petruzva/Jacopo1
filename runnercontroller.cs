using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runnercontroller : MonoBehaviour
{
    float movementSpeed = 4;

    float jumpSpeed = 10;

    Rigidbody2D myRigidbody;

    private void Awake() 
   
    {
        myRigidbody = GetComponent<Rigidbody2D>();

        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            //  myRigidbody.AddForce(Vector3.up, ForceMode2D.Impulse);

            // Vector2 tempVelocity = myRigidbody.velocity;
            // tempVelocity.y = jumpSpeed;
            // myRigidbody.velocity = tempVelocity; 

            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpSpeed);
        }
            if (Input.GetKeyUp(KeyCode.Space) && myRigidbody.velocity.y > 0) {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, myRigidbody.velocity.y / 6);

            }

        
    }
    private void FixedUpdate() 
        {
            //myRigidbody.velocity = Vector2.right * movementSpeed;


            //salvo la velocisà corrente
            Vector2 tempVelocity = myRigidbody.velocity;

            tempVelocity.x = movementSpeed;

            myRigidbody.velocity = tempVelocity;


        }
    }
    

