using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SlimWoman : MonoBehaviour
{

    public GameObject slimWoman;

  //  public static int scoreCounter = 0;
  //  public static int highScoreCounter;
    
    

                                                                                            

    public void OnCollisionEnter(Collision collision)
    {                           
        if (collision.collider.tag == "Man"                      )                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
        {                                                                                                                                                                                             
           
            Destroy(gameObject);
          //  AddScore();
           // HighScoreMenu.Instance.Save();
            
            
        }
        if (collision.collider.tag == "Ground")
        {
            
            Vector3 position = collision.contacts[0].point;
            Quaternion rotation = Quaternion.LookRotation(collision.contacts[0].normal);

            Quaternion rot = Quaternion.Euler(transform.eulerAngles.x + 45,0, 0);
            Instantiate(slimWoman, transform.position, rot);
           

            Destroy(gameObject);



        }



    }
  //  public void AddScore()
   // {
      //  scoreCounter++;
      //  highScoreCounter++;
       

   // }
}

  
 

    
        
    

