using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliteRock : MonoBehaviour
{
    public GameObject gameObject;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        Destroy(gameObject, 0.5f);
    }
   
}
