using UnityEngine;

[CreateAssetMenu(fileName = "Unnamed Currency", menuName = "New Currency")]
public class Currency : SpriteSheet
{
    [Header("Script Info")]
    public string title;
    public int amount;
}