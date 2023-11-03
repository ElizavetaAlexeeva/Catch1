using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
   public  int score ;
   public  int scoreMax;
   public  Text scoreMaxText;
    public Text scoreText;
   

                                                                                                                                                                                                        
    public void Awake()
    {

        // scoreMax = PlayerPrefs.GetInt("HighScore");
          scoreText = GetComponent<Text>();
          scoreMaxText = GetComponent<Text>();

        //  scoreText.text = score.ToString();


        //  scoreMaxText.text = PlayerPrefs.GetInt("HighScore").ToString();

          scoreMaxText.text = Progress.Instance.PlayerInfo.score.ToString();


        //   scoreMax = Progress.Instance.PlayerInfo.score;



    }

    void Update()
    {   
       // score = SlimWoman.scoreCounter;       
       // scoreMax = SlimWoman.highScoreCounter;
        scoreText.text = score.ToString();
        //scoreMaxText.text = scoreMax.ToString();

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
