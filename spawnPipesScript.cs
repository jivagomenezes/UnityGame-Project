using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPipesScript : MonoBehaviour
{
    public GameObject pipes;
    public float offset = 6;
    public float spawnRate = 3;
    private float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        float pontoBaixo = transform.position.y - offset;
        float pontoAlto = transform.position.y + offset;

        // isto faz com que  
        Instantiate(pipes, new Vector3(transform.position.x, Random.Range(pontoBaixo, pontoAlto), 0), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (time < spawnRate)
        {
            time = time + Time.deltaTime;
        }
        else
        {
            spawnPipes();
            time = 0;
        }
    }
    void spawnPipes()
    {
        float pontoBaixo = transform.position.y - offset;
        float pontoAlto = transform.position.y + offset;

        // isto faz com que  
        Instantiate(pipes, new Vector3(transform.position.x, Random.Range(pontoBaixo, pontoAlto), 0), transform.rotation);
    }

        }