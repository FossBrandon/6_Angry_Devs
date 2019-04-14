﻿/* Brandon Foss
 * This script inherits from the base collision class and modifies
 * the OnTriggerEnter method to perform as intended for a rock impact
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockCollision : Collision
{
    void Start() 
    {
        base.DoInitialization(); // calls base class initialization
        damage = 25; // changes damage value after initialization
    }

    // ovverides method to form to rock collisions
    public override void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Scripts").SendMessage("HealthChangeDamage", damage); // calls damage script
        audioHandler.PlayAudio("rock impact"); // calls audio script to play rock sounds
    }
}

