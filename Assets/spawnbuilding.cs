using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnbuilding : MonoBehaviour
{
    public GameObject buildingload;
    public float pipeOffset = 2;
    public float timer;
    public float spawnrate = 2;
    // Start is called before the first frame update
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
            //delta time to make sure it will not go too fast because of the fps
        }
        else
        {
            spawnpipe();
            timer = 0;
        }
    }
    void spawnpipe()
    {
        float lowestvalue = transform.position.y - pipeOffset;
        float highestvalue = transform.position.y + pipeOffset;
        Instantiate(buildingload, new Vector3(transform.position.x, Random.Range(lowestvalue, highestvalue),transform.position.z), transform.rotation);
        //instantiate is to spawn pipes,and random is form random placement of building
    }
}
