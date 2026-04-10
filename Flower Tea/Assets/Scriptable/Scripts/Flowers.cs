using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Unnamed Flowers", menuName = "Items/New Flowers")]
public class Flowers : SpriteSheet
{
    [Header("Game Info")]
    public string title;
    public Stages stage;
    public List<Ingredients> ingredients;

    [Header("Script Info")]
    public int cost;

    public void setIndex()
    {
        index = (int)stage;
    }
}

public enum Stages
{
    Seed,
    Sprout,
    Seedling,
    Vegetating,
    Budding,
    Flowering,
    Ripening,
    Senescence
}