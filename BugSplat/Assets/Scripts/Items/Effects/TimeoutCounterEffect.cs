﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Effects/Timed Counter")]
public class TimeoutCounterEffect : CounterEffect
{
    public float TimeoutTime;

    private EmptyMono CoroutineBoy;

    public override void Init() {
        base.Init();

        CoroutineBoy = MakeCoroutineObject();
        CoroutineBoy.name = "TimeoutCounterEffect_CoroutineBoy";
    }

    public override void Trigger(GameObject target = null) {
        base.Trigger();

        CoroutineBoy.StopCoroutine("Timeout");
        CoroutineBoy.StartCoroutine("Timeout");
    }

    private IEnumerator Timeout() {
        yield return new WaitForSeconds(TimeoutTime);

        base.Init();
    }
}