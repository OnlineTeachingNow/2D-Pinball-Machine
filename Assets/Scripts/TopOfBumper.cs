using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopOfBumper : MonoBehaviour
{
    [SerializeField] List<Sprite> _bumperColorSprites;
    SpriteRenderer _mySprite;
    Sprite _sameColorSprite;
    int _indexOfSameColor;

    private void Start()
    {
        _mySprite = GetComponent<SpriteRenderer>();
        PreventSameColorBeingChosen();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "The Almighty Ball")
        {
            Sprite _newSprite = _bumperColorSprites[Random.Range(1, 4)];
            _mySprite.sprite = _newSprite;
            PreventSameColorBeingChosen();
        }
    }
    private void PreventSameColorBeingChosen()
    {
        for (int spriteIndex = 0; spriteIndex < _bumperColorSprites.Count; spriteIndex++)
        {
            string _spriteName = _bumperColorSprites[spriteIndex].name;
            if (_spriteName == _mySprite.sprite.name)
            {
                _sameColorSprite = _bumperColorSprites[spriteIndex];
                _indexOfSameColor = spriteIndex;
                break;
            }
        }
        _bumperColorSprites.RemoveAt(_indexOfSameColor);
        _bumperColorSprites.Insert(0, _sameColorSprite);

        /*
        foreach (Sprite sprite in _bumperColorSprites)
        {
            Debug.Log(sprite.name);
        }
        */
    }
}
