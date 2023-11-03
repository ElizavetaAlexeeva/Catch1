using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyMove : MonoBehaviour
{
   public Rigidbody m_Rigidbody;
    public float m_Speed ;
    public float rotationSpeed;
    private Vector3 moveVector;

    void Start()
    {
       
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        

        Vector3 movenmentDirection = new Vector3(horizontalInput, 0, 0);
        movenmentDirection.Normalize();

        transform.Translate(movenmentDirection * m_Speed * Time.deltaTime);

        if(movenmentDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movenmentDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }
   

    
    void Update()
    {
        
    }
}
