using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform targetTofollow;
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //riposiziono la camera su x del giocatore y e z camera
        transform.position = new Vector3( targetTofollow.position.x + 10,transform.position.y, transform.position.z);
        
    }
}
