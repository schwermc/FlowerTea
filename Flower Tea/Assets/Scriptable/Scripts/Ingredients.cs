using UnityEngine;

[CreateAssetMenu(fileName = "Unnamed Ingredient", menuName = "Items/New Ingredient", order = 0)]
public class Ingredients : ScriptableObject
{
    [Header("Game Info")]
    public string title;
    public int amount;
    [TextArea(3, 5)] public string description;
    public Sprite sprite;
}