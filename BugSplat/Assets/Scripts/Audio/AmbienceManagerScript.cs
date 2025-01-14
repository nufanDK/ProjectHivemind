﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbienceManagerScript : MonoBehaviour
{

    [Header("Wwise ambience events")]
    public AK.Wwise.Event arenaAmbience;
    public AK.Wwise.Event arenaAmbStop;
    public AK.Wwise.Event hubAmbience;
    public AK.Wwise.Event hubAmbStop;


    [Header("Wwise reverb states")]
    public AK.Wwise.State Arenaverb;
    public AK.Wwise.State Hubverb;
    public AK.Wwise.State Shopverb;


    public void ArenaSceneLoad()
    {
        arenaAmbience.Post(this.gameObject);
        Arenaverb.SetValue();
        
    }

    public void HubSceneLoad()
    {
        hubAmbience.Post(this.gameObject);
        Hubverb.SetValue();
    }


    public void ArenaAmbStopEvent()
    {
        arenaAmbStop.Post(this.gameObject);
    }

    public void HubAmbStopEvent()
    {
        hubAmbStop.Post(this.gameObject);
    }


}
