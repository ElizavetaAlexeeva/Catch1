using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using TMPro;

public class Yandex : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void Hello();

    [DllImport("__Internal")]
    public static extern void GiveMePlayerData();

    [SerializeField]
    TextMeshProUGUI nameText;

    public void Start()
    {
        GiveMePlayerData();
        SetName( name);
    }

    //  public void HelloButton()
    // {
    //     GiveMePlayerData();
    // }

    public void SetName(string name)
    {
        nameText.text = name;
    }
}
