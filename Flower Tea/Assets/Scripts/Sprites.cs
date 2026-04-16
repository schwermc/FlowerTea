using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Sprites : MonoBehaviour
{
    public float time = 15f;
    public float wilting = 30f;
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
            else
                yield return new WaitForSeconds(wilting);
            SpriteChange();
            isGrowing = true;
        }
    }
}