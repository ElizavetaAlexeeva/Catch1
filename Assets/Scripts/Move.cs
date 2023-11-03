using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    public ParticleSystem dust;
    public float speedMove;

    private Vector3 moveVector;
    private Animator ch_animator;
    
    public Joystick joystick;
    public Rigidbody m_Rigidbody;
    private UnityEngine.Object explosion;
    public GameObject man;
    public AudioSource soundExplosion;
    public AudioSource ooo;
    // [SerializeField] private float persentShowAds;

    public GameObject dust1;

    public static int score =0;
    public  int scoreMax;
    public Text scoreMaxText;
    public Text scoreText;





    
    void Start()
    {
        
       ch_animator = GetComponent<Animator>();
        m_Rigidbody = GetComponent<Rigidbody>();
        explosion = Resources.Load("Explosion");
        // InterstitialAd.S.LoadAd();

        //  scoreMax= Progress.Instance.PlayerInfo.score;

         scoreMax = PlayerPrefs.GetInt("HighScore");
         scoreMaxText.text = scoreMax.ToString();
        scoreText.text=score.ToString();

             

    }


    void FixedUpdate()
    {
        CharacterMove();
        
        
    }

        private void CharacterMove()
        {

            moveVector.x = Input.GetAxis("Horizontal") * speedMove;
            moveVector.x = joystick.Horizontal * speedMove;


        if (moveVector.x != 0)
        {
            ch_animator.SetBool("Run", true);
            // dust.Play();
            dust1.SetActive(true);
            
        }
        else {
            ch_animator.SetBool("Run", false);
           
              // dust.Pause();
              dust1.SetActive(false);
              }
            
            if (Vector3.Angle(Vector3.forward, moveVector) > 1f || Vector3.Angle(Vector3.forward, moveVector) == 0)
            {
                Vector3 direct = Vector3.RotateTowards(transform.forward, moveVector, speedMove, 0.0f);
                transform.rotation = Quaternion.LookRotation(direct);
           // dust.Pause();
           
        }
            m_Rigidbody.MovePosition(transform.position + moveVector * Time.deltaTime * speedMove);
        
    }

        

        void OnCollisionEnter(Collision collision)
        {
            //  IsGroundedUpate(collision, true);
           if (collision.gameObject.tag == ("rock"))
            {
            GameObject explosionRef = (GameObject)Instantiate(explosion);
            soundExplosion.Play();
            explosionRef.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            gameObject.SetActive(false);

            if (PlayerPrefs.GetInt("HighScore") < score)
            {
                PlayerPrefs.SetInt("HighScore", score);
            }
               // if (score > scoreMax)
           // {
               // scoreMax = score;
              //  Progress.Instance.PlayerInfo.score = scoreMax;
             //   Progress.Instance.Save();
           // }
            score = 0;
            
           

            //ShowAdsPersent();
            //soundExplosion.Play();
            // Destroy(gameObject);
            // Instantiate(man, transform.position, transform.rotation);

          //  Invoke("LoadMenu", 2f);
            Invoke ("RestartLevel", 3f);
         
           
            
            }


            if (collision.gameObject.tag == ("SlimWoman"))
            {
            ooo.Play();
            ch_animator.SetTrigger("Hand_Trigger");
            score++;
                    
            
            scoreText.text = score.ToString();
            

            // if (score > scoreMax)
            /// {
            //  Progress.Instance.PlayerInfo.score = score;
            //  }
            //  if (score > Progress.Instance.PlayerInfo.score)
            // {
            //     Progress.Instance.PlayerInfo.score = score;
            // }

            // if (PlayerPrefs.GetInt("HighScore") < score)
            // {
            //   PlayerPrefs.SetInt("HighScore", score);
            //   Progress.Instance.playerInfo.score=score;
            //  }

        }

             
    }
    public void ButtonExitClick()
    {
        if (PlayerPrefs.GetInt("HighScore") < score)
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
   // public void ShowAdsPersent()
   // {
     //   float tempPersent = Random.Range(0f, 1f);
       // if (tempPersent < persentShowAds)
       // {
       //     InterstitialAd.S.ShowAd();
       // }
   // }
  //  public void LoadMenu()
   // {
     //   SceneManager.LoadScene("Loading Scena");
      //  Progress.Instance.Save();
    //}

      

       public void RestartLevel()
    {
     //   Progress.Instance.Save();
       SceneManager.LoadScene("PlayScene");
   }

    } 

