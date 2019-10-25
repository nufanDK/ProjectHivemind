﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDodgeScript : GameLoop
{
    public Rigidbody player;
    public GameEvent DashInitiated;
    public BoolVariable IsDodging;
    public Vector3Variable PlayerSpeedDirectionSO;
    public AnimationCurve DodgeAnimationCurve;
   
    // Initial speed of dash
    public float DashSpeed;

    // Number of frames the dash lasts
    public float DashLength;

    private Vector3 _dashDirection;
    private int _dashFrameCount;

    // Called from inputmanager
    public void StartDash()
    {
        DashInitiated.Raise();
    }

    // Called from PlayerController
    public void PlayerDash()
    {
        
        if (IsDodging.Value == false)
        {
            _dashDirection = PlayerSpeedDirectionSO.Value;
            _dashFrameCount = 0;
            IsDodging.Value = true;
        }
    }

    private void dashCurve()
    {

    }

    
    public override void LoopUpdate(float deltaTime)
    {
        Debug.Log("Dodging : " + IsDodging.Value);

        
        if (IsDodging.Value == true)
        {
            Vector3 newPosition = _dashDirection*DashSpeed;
            PlayerSpeedDirectionSO.Value = newPosition;
            
            // Only for Testing !TEST
            player.MovePosition(player.transform.position + PlayerSpeedDirectionSO.Value);
            

            
            _dashFrameCount++;

            if (_dashFrameCount >= DashLength)

                // Only for Testing !TEST
                PlayerSpeedDirectionSO.Value = _dashDirection;

                IsDodging.Value = false;
        }
       
    }

    public override void LoopLateUpdate(float deltaTime)
    {
       
    }

    


}