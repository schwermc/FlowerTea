using System.Collections.Generic;
using UnityEngine;

public class OnQuit : MonoBehaviour
{
    [SerializeField] List<SpriteSheet> _spriteSheet;

    void OnApplicationQuit()
    {
        foreach(var spriteSheet in _spriteSheet)
        {
            spriteSheet.SpriteReset();
        }
    }
}