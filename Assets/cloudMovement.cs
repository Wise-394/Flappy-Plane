using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudMovement : MonoBehaviour
{
    public float gone = -45;
    public float fastest = 5;
    public float slowest = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position += Vector3.left * Random.Range(slowest,fastest) * Time.deltaTime;
        if (transform.position.x < gone)
        {
            Destroy(gameObject);
        }
    }
}
