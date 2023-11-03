using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManKick : MonoBehaviour
{
    private Animator animator;
    private Move Move;
    void Start()
    {
        animator = GetComponent<Animator>();


        StartCoroutine(inst());
      //  StartCoroutine(inst1());
        

    }


    IEnumerator inst()
    {
        while (Move.score < 5)

        {
            animator.SetTrigger("Kick");
            
            yield return new WaitForSeconds(3f);


            if (Move.score == 5)
            {
                // yield break;
                yield return StartCoroutine(inst2());
            }
        }
    }

  //  IEnumerator inst1()
   // {
      //  while (SlimWoman.scoreCounter < 5)

       // {

         //   animator.GetComponent<Animator>().SetBool("kick", false);
          //  yield return new WaitForSeconds(3.2f);


           // if (SlimWoman.scoreCounter == 5)
           // {
                // yield break;
              //  yield return StartCoroutine(inst3());
          //  }
       // }


  //  }
    IEnumerator inst2()
    {
        if (Move.score == 5)
            while (Move.score < 10)
            {
                animator.SetTrigger("Kick");
                yield return new WaitForSeconds(2f);

                if (Move.score == 10)
                {
                    // yield break;
                    yield return StartCoroutine(inst4());
                }
            }
    }
  //  IEnumerator inst3()
   // {
      //  if (SlimWoman.scoreCounter == 5)
        //    while (SlimWoman.scoreCounter < 10)
         //   {
              //  animator.GetComponent<Animator>().SetBool("kick", false);
              //  yield return new WaitForSeconds(2.1f);

              //  if (SlimWoman.scoreCounter == 10)
               // {
                    // yield break;
                   // yield return StartCoroutine(inst5());
               // }
          //  }
   // }
    IEnumerator inst4()
    {
        if (Move.score == 10)
            while (5 < 10)
            {
                animator.SetTrigger("Kick");
                yield return new WaitForSeconds(1f);
            }
    }
  //  IEnumerator inst5()
    //{
       // if (SlimWoman.scoreCounter == 10)
        //    while (5 < 10)
          //  {
            //    animator.GetComponent<Animator>().SetBool("kick", false);
           //     yield return new WaitForSeconds(1.2f);
           // }
    //}
}

    
        

    
   

