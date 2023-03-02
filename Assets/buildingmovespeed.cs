using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingmovespeed : MonoBehaviour
{
    public float gone = -10;
    public float movespeed = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * movespeed * Time.deltaTime;
        //to move the building per frame
        if (transform.position.x < gone)
        {
            Destroy(gameObject);
            //if the building go too far it will get deleted
        }
    }
}
