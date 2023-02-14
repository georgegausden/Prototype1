using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class passedThrough : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.CompareTag("passedThrough"))
    {
        GameObject targetObject = GameObject.Find("TargetObject");
        targetObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}

}
