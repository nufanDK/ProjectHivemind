﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Effects/Projectile")]
public class ProjectileEffect : Effect
{
    public GameObject Particles;
    private ParticleSystem ParticleSystem;

    public override void Init()
    {
        Particles = Instantiate(Particles);
        ParticleSystem = Particles.GetComponentInChildren<ParticleSystem>();
    }

    public override void Trigger(GameObject effectTarget = null)
    {
        ParticleSystem.Emit(1);
    }
}
