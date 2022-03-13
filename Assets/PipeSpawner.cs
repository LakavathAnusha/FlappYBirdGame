using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float ymin;
    public float ymax;
    public float time;
    BirdMovement birdMovement;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawner", 2f, 2f);
    }

    private void Spawner()
    {
        if (birdMovement.isGameOver == false)
        {
            time = time + Time.deltaTime;
            // if (time > 2f)
            //{
            GameObject newPipe = Instantiate(pipePrefab);
            newPipe.transform.position = new Vector2(transform.position.x, UnityEngine.Random.Range(ymin, ymax));


        }
    }

    // Update is called once per frame
    void Update()
    {
      /* time = time + Time.deltaTime;
        if(time>2f)
        {
            Invoke("Spawner", 5f);
            time = 0f;
        }
        else if(time>3f)
        {
            CancelInvoke("Spawner");
        }*/
    }
}
