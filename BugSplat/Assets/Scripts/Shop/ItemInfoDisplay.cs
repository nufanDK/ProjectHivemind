﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfoDisplay : MonoBehaviour
{
    public ShopSlot Slot;

    public TMPro.TextMeshProUGUI TitleText, DescriptionText;

    void OnEnable() {
        UpdateInfo();
    }

    public void UpdateInfo() {
        TitleText.text = Slot.GetTitle();
        DescriptionText.text = Slot.GetDescription();
    }
}
