﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LoadTutorial : MonoBehaviour
{

    public BoolVariable TutorialIsActive;
    public BoolVariable PlayerControlOverrideSO;
    public Transform Player;
    public GameObject Cage;

    void OnEnabled()
    {
        if(TutorialIsActive.Value == false)
        {
            PlayerControlOverrideSO.Value = false;
            Player.GetComponent<NavMeshAgent>().enabled = true;
        } else
        {
            Cage.SetActive(true);
        }
    }

}