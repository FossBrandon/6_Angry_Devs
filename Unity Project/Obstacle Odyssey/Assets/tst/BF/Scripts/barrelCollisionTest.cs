﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelCollisionTest : MonoBehaviour
{
    // bind audio
    AudioHandler audioHandler;
    void Start()
    {
        //audioHandler = AudioHandler.instance;
    }

    private float damage = 1; // set to this for testing

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Scripts").SendMessage("HealthChangeDamage", damage);
        //audioHandler.PlayAudio("barrel impact");
    }
}
