using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birbscript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flapstrength=10;
    public logicscript logic;
    public bool birdisalive=true;
    // Start is called before the first frame update
    void Start()
    {
        logic= GameObject.FindGameObjectWithTag("Logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space)==true && birdisalive==true) 
       {
        rb.velocity=Vector2.up * flapstrength ;
       }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        logic.gameOver();
        birdisalive=false;
    }
}
