using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;





public class HighScoreMenu : MonoBehaviour
{
   


    public  Text  highScoreMenu;

   
    void Start()
    {
      // highScoreMenu.text = "High Score: " + Progress.Instance.playerInfo.score.ToString();

        highScoreMenu.text =  PlayerPrefs.GetInt("HighScore").ToString();
    }

   
   
}
