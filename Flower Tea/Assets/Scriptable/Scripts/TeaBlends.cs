using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Unnamed Blend", menuName = "Items/New Blend")]
public class TeaBlends : ScriptableObject
{
    [Header("Game Info")]
    public string title;
    [TextArea(3, 5)] public string description;
    public List<Ingredients> ingredients;
    public Sprite sprite;

    [Header("Script Info")]
    public int cost;
}