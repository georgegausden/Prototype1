using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObject : MonoBehaviour
{
    public float rotationSpeed = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //FixedUpdate is garanteed to work (it will not miss any frames)
    void FixedUpdate()
    {
       
        this.GetComponent<Transform>().Rotate(0, rotationSpeed, rotationSpeed);
         
   
    }
}
