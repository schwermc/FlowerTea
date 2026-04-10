using UnityEngine;

public class SpriteSheet : ScriptableObject
{
    [Header("Sprite Info")]
    public Sprite[] animation;
    public Sprite spriteIcon;
    public int index;

    [Header("Children Info")]
    public bool useFlower;
    public Flowers flower;
    public bool useCurrency;
    public Currency currency;

    public void UpdateIndex()
    {
        if (useFlower)
        {

            return;
        }
        if (useCurrency)
        {

            return;
        }
    }

    public void SpriteChange()
    {
        if (animation.Length != 0 && animation.Length > index)
        {
            Debug.Log(animation.Length + " : " + index);
        }
    }
}