using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject cloud;
    public GameObject pipe;
    public float spawnrate = 2;
    private float timer = 0;
    public float pipeOffset = 10;
    public float lowestCloud = 17;
    public float highestCloud = -17;
    // Start is called before the first frame update
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else 
        {
            spawnpipe();
            spawncloud();
            timer = 0;
        }
       
    }
    void spawnpipe()
    {
        float lowestvalue = transform.position.y - pipeOffset;
        float highestvalue = transform.position.y + pipeOffset;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestvalue,highestvalue),0), transform.rotation);
    }
    void spawncloud()
    {
        Instantiate(cloud,new Vector3(transform.position.x,Random.Range(lowestCloud,highestCloud),transform.position.z), transform.rotation);
    }
}
