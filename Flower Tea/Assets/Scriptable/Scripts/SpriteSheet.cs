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

    public void IncreaseSpriteChange()
    {
        if (animation.Length != 0 && animation.Length > index)
        {
            if (animation.Length - 1 == index)
            {
                index = -1;
            }
            index++;
            spriteIcon = animation[index];
            return;
        }
    }

    public void DecreaseSpriteChange()
    {
        if (animation.Length != 0 && animation.Length > index)
        {
            index--;
            if (index == -1)
            {
                index = animation.Length - 1;
            }
            spriteIcon = animation[index];
            return;
        }
    }

    public void SpriteReset()
    {
        index = 0;
        spriteIcon = animation[index];
    }
}