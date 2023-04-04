using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D birdRigidBody;
    public int forca = 1;
    public bool crashed = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")==true && crashed==false)
        {
            birdRigidBody.velocity = Vector2.up * forca;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        crashed = true;
    }
}
