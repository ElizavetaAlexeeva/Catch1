using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManKick1 : MonoBehaviour
{
    private Animator animator;
    private Move Move;
    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {
       if (Move.score < 5)

        {
            InvokeRepeating("Kick", 1f, 3f);




            if (Move.score == 5)
            {
                // yield break;
               // yield return StartCoroutine(inst2());
            }
        }
    }
    private void Kick()
    {
        animator.SetBool("kick", true);
    }
}
