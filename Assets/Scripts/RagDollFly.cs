﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagDollFly : MonoBehaviour
{
    public List<Rigidbody> GetRigidbodies = new List<Rigidbody>();
    void Start()
    {
        GetRigidbodies.AddRange(GetComponentsInChildren<Rigidbody>());

        RigidbodyIsKinematicOn();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void RigidbodyIsKinematicOn()
    {
        for (int i = 0; i < GetRigidbodies.Count; i++)
        {
            GetRigidbodies[i].isKinematic = true;
        }
    }
    public void RigidbodyIsKinematicOff()
    {
        for (int i = 0; i < GetRigidbodies.Count; i++)
        {
            GetRigidbodies[i].isKinematic = false;
        }
    }
}
