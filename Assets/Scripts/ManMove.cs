using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManMove : MonoBehaviour
{



    // т.к. логика движения изменилась мы выставили меньшее и более стандартное значение
    public float Speed = 5f;
    public int energyTotal = 3;
    public int score = 0;
    private Vector3 moveVector;
    public CharacterController ch_controller;
    private Animator ch_animator;

    //что бы эта переменная работала добавьте тэг "Ground" на вашу поверхность земли
    private bool _isGrounded;


    void Start()
    {
        ch_controller = GetComponent<CharacterController>();
        ch_animator = GetComponent<Animator>();
    }


    void FixedUpdate()
    {

        MovementLogic();
     RotateMan();
    }

    private void MovementLogic()
    {
        
          float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3( 0.0f,  0.0f, moveHorizontal);

        transform.Translate(movement * Speed * Time.fixedDeltaTime);


        if (moveHorizontal != 0)
            ch_animator.SetBool("Run", true);
        else ch_animator.SetBool("Run", false);
       
        }
    void RotateMan()
    {
        if (Vector3.Angle(Vector3.forward, moveVector) > 1f || Vector3.Angle(Vector3.forward, moveVector) == 0)
        {
            Vector3 direct = Vector3.RotateTowards(transform.forward, moveVector, Speed, 0.0f);
            transform.rotation = Quaternion.LookRotation(direct);
        }

        ch_controller.Move(moveVector * Time.deltaTime);
    }
    //  if(Input.GetKey(KeyCode.A))
    //    transform.Rotate()
    // transform.localRotation = Quaternion.Euler(0, 90, 2);

    //  if (Input.GetKey(KeyCode.D))
    // transform.localRotation = Quaternion.Euler(0, -90, 2);
}


    

        

        



    


