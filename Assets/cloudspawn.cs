using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudspawn : MonoBehaviour
{
    public GameObject cloud;
    private float cloudtimer=0;
    public float cloudspawnrate=2;
 
    void Start()
    {
        spawncloud();
    }

    
    void Update()
    {
        if(cloudtimer<cloudspawnrate)
        {
        cloudtimer+=Time.deltaTime;}
        else{
            spawncloud();
            cloudtimer=0;
        }
       
    }
    void spawncloud()
    {
Vector3 randomVector= new Vector3(Random.Range(-5f, 5f), 0);
        Instantiate(cloud, randomVector, transform.rotation);
    }
}


