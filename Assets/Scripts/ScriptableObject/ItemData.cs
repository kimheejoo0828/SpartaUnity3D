using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public enum ItemType
{
    Consumable
}

public enum ConsumableType
{
    Hunger,
    Health,
    Speed
}

[System.Serializable]
public class ItemDataConsumable
{
    public ConsumableType type;
    public float value;
}

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string displayName;
    public string description;
    public ItemType type;
    public Sprite Icon;
    public GameObject dropPrefab;

    [Header("stacking")]
    public bool canStack;
    public int maxstackAmount;

    [Header("Consumable")]
    public ItemDataConsumable[] consumables;
}
