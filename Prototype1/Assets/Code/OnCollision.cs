using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    public GameObject player;
    public Vector3 newObjectPosition;
    public Quaternion newObjectRotation;
    public MeshFilter playerMeshFilter;
    public Collider playerCollider;




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
        if (collision.collider.gameObject.CompareTag("Playable"))
        {

            //store the mesh info of the object
            Mesh newObjectMesh = collision.gameObject.GetComponent<MeshFilter>().mesh;
            playerMeshFilter.mesh = newObjectMesh;

            //switch the collider of the object
            Collider newObjectCollider = collision.gameObject.GetComponent<Collider>();

            if (newObjectCollider is BoxCollider)
            {
                Destroy(playerCollider);
                playerCollider = gameObject.AddComponent<BoxCollider>();
            }
            else if (newObjectCollider is SphereCollider)
            {
                Destroy(playerCollider);
                playerCollider = gameObject.AddComponent<SphereCollider>();
            }


           

            

            //Transform newObjectTransform = collision.transform;
            //newObjectPosition = newObjectTransform.position;
            //newObjectRotation = newObjectTransform.rotation;

           

            //transform.position = newObjectPosition;
            //transform.rotation = newObjectRotation;

            ////remove the old object
            //Destroy(collision.gameObject);

        }
    }

}
