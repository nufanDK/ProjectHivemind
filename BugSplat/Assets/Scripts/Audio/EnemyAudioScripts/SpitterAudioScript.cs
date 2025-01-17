﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpitterAudioScript : MonoBehaviour
{
    [Header("Wwise events")]
    public AK.Wwise.Event Detect;
    public AK.Wwise.Event Attack;
    public AK.Wwise.Event Hit;
    public AK.Wwise.Event ScaredScream;
    public AK.Wwise.Event DeathSplat;
    public AK.Wwise.Event Charge;
    public AK.Wwise.Event EmergeFromGround;


    public void DetectEvent(GameObject source)
    {
        Detect.Post(source);
    }

    public void AttackEvent(GameObject source)
    {
        Attack.Post(source);
    }

    public void HitEvent(GameObject source)
    {
        Hit.Post(source);
    }

    public void Scared(GameObject source)
    {
        ScaredScream.Post(source);
    }

    public void Death(GameObject source)
    {
        DeathSplat.Post(source);
    }

    public void ChargeEvent(GameObject source)
    {
        Charge.Post(source);
    }

    public void EmergeEvent(GameObject source)
    {
        EmergeFromGround.Post(source);
    }

}
