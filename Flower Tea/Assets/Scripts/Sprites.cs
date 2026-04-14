using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Sprites : MonoBehaviour
{
    public float time = 15f;
    public bool isGrowing = true;

    [SerializeField] SpriteSheet _spriteSheet;
    [SerializeField] Image _uiImage;

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
        _spriteSheet.SpriteChange();
        _uiImage.sprite = _spriteSheet.spriteIcon;
    }

    IEnumerator growingTimer()
    {
        isGrowing = false;
        if (_spriteSheet.animation.Length - 1 != _spriteSheet.index)
        {
            yield return new WaitForSeconds(time);
            SpriteChange();
            isGrowing = true;
        }
    }
}