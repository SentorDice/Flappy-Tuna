using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdBehavior : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
        }
        
    }
}
