using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Sprites : MonoBehaviour
{
    public float time = 15f;
    public bool isGrowing = true;

    [SerializeField] SpriteSheet _sprites;
    [SerializeField] Image _uiImage;

    private SpriteSheet _spriteSheet;

    void Awake()
    {
        _spriteSheet = Instantiate(_sprites);
    }

    void Start()
    {
        if (_uiImage == null) { _uiImage = GetComponent<Image>(); }
        _uiImage.sprite = _spriteSheet.spriteIcon;
    }

    void Update()
    {
        if (isGrowing) { StartCoroutine("growingTimer"); }
    }

    public void SpriteChange()
    {
        _spriteSheet.IncreaseSpriteChange();
        _uiImage.sprite = _spriteSheet.spriteIcon;
    }

    IEnumerator growingTimer()
    {
        isGrowing = false;
        if (_spriteSheet.animation.Length - 1 != _spriteSheet.index)
        {
            if (_spriteSheet.animation.Length - 2 != _spriteSheet.index)
                yield return new WaitForSeconds(time);
            SpriteChange();
            isGrowing = true;
        }
    }

    public bool isWilted()
    {
        if (_spriteSheet.animation.Length - 1 == _spriteSheet.index) { return true; }
        return false;
    }

    public void updateSprite(SpriteSheet sprite)
    {
        Destroy(_spriteSheet);
        _spriteSheet = Instantiate(_sprites);
        _spriteSheet.index = -1;
        SpriteChange();
        isGrowing = true;
    }
}