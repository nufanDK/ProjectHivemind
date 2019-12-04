﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;


public class PosProcessingToggleScript : GameLoop


{
    public PostProcessVolume Volume;
    public PostProcessLayer Layer;


    public BoolVariable Toggle;

    public override void LoopLateUpdate(float deltaTime)
    {
        

    }

    public override void LoopUpdate(float deltaTime)
    {

        if (Volume.enabled != Toggle.Value)
        {
            Volume.enabled = Toggle.Value;

            Layer.enabled = Toggle.Value;
        }
    }
}
