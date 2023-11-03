using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockshutter : MonoBehaviour
{

    public GameObject rockShuttered;
   


    // void OnTriggerEnter(Collider other)
    //{

    //  Instantiate(rockShuttered, transform.position, transform.rotation);
    //GetComponent<Rigidbody>().AddExplosionForce(400, transform.position, 5);
    // Destroy(gameObject);



    // }

    void OnCollisionEnter(Collision collision)
    {
        //  IsGroundedUpate(collision, true);
        if (collision.gameObject.tag == ("Ground"))
        {
            
            Instantiate(rockShuttered, transform.position, transform.rotation);
            GetComponent<Rigidbody>().AddExplosionForce(600, transform.position, 10);
            Destroy(gameObject);

        }
    }
}
