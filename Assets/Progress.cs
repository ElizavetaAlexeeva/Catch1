using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;



[System.Serializable]
    public class PlayerInfo
    {
        public int score =0;

    }

    public class Progress : MonoBehaviour
    {
        public Text highScoreMenu;
        public PlayerInfo PlayerInfo;

        [DllImport("__Internal")]
        private static extern void SaveExtern(string date);
        [DllImport("__Internal")]
        private static extern void LoadExtern();

        public static Progress Instance;

        public void Start()
        {
            if (Instance == null)
            {
                 transform.parent = null;
                 DontDestroyOnLoad(gameObject);
                 Instance = this;
                
            Debug.Log("Progress creating in 2 scene");

           
            LoadExtern();

        }
        else
            {
                Destroy(gameObject);
            }
        }

       

        public void Save()
        {
            string jsonString = JsonUtility.ToJson(PlayerInfo);

            SaveExtern(jsonString);

        }

        public void SetPlayerInfo(string value)
        {
            PlayerInfo = JsonUtility.FromJson<PlayerInfo>(value);
            highScoreMenu.text = PlayerInfo.score.ToString();

        }
    }


