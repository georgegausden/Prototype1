using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    public pickupCoin player; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.count >= 3)
        {
            Debug.Log("achieved");
            transform.Rotate(0f, 90f, 0f, Space.Self);
            player.count = 0;
        }
    }

    public void RotateObject90Degrees()
    {
        
       
    }
}
