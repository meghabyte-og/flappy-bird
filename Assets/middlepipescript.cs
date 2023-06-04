using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middlepipescript : MonoBehaviour
{
    public logicscript logic;
    void Start() {
        {
            logic=GameObject.FindGameObjectWithTag("Logic").GetComponent<logicscript>();
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.layer==3){
                    logic.addScore(1);
        }
    }
}