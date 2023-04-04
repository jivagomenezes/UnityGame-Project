using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMovement : MonoBehaviour
{

    public int movimento = 10;
    public float deleteObject = -7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movimento) * Time.deltaTime;
        if (transform.position.x < deleteObject)
        {
            Destroy(gameObject);
        }
        
    }
}
