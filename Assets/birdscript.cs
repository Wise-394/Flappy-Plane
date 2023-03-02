using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public float velocityup;
    public Rigidbody2D myRigidbody;
    public LogicScript logic;
    public bool planeCrash = false;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true && planeCrash == false)
        {
         myRigidbody.velocity = Vector2.up * velocityup;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        planeCrash = true;
        logic.gameOver();
    }
}
