using UnityEngine;

public class Sprites : MonoBehaviour
{
    [SerializeField] SpriteSheet _spriteSheet;

    void Start()
    {
        _spriteSheet.SpriteChange();
    }

    void Update()
    {
        
    }

}
