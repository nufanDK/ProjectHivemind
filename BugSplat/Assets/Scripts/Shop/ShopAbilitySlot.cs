﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName="Shop/AbilitySlot")]
public class ShopAbilitySlot : ShopSlot
{
    public Effect Ability;

    public int Price;

    public Sprite Sprite;

    public override Sprite GetSprite() => Sprite;

    public override int GetPrice() => Price;

    public override void OnPurchase()
    {
        Ability.Trigger();
    }

    public override void Init()
    {
    }

    public override void Reset()
    {
    }
}
