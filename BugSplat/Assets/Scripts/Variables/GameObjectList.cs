﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(menuName = "Variables/Lists/GameObjectList")]
public class GameObjectList : ScriptableObject
{
    public List<GameObject> List;
}
