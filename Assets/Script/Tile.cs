using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tile : MonoBehaviour
{
    #region Parameters
    [SerializeField]
    private Attribute _attribute;

    [SerializeField]
    private Vector2Int _index;

    public Vector2Int index
    {
        get
        {
            return _index;
        }
    }
    #endregion

    #region Internal Reference
    [SerializeField]
    private Image attributeImage;
    #endregion

    #region External Reference
    [SerializeField]
    private Sprite waterSprite;

    [SerializeField]
    private Sprite fireSprite;

    [SerializeField]
    private Sprite lightSprite;
    #endregion

    public void Initialize(Vector2Int index)
    {
        _index = index;
    }

    public void SetEnemy()
    {

    }

    public void SetAttribute(Attribute attribute)
    {
        _attribute = attribute;

        switch (attribute)
        {
            case Attribute.None:
                attributeImage.gameObject.SetActive(false);
                break;

            case Attribute.Water:
                attributeImage.gameObject.SetActive(true);
                attributeImage.sprite = waterSprite;
                break;

            case Attribute.Fire:
                attributeImage.gameObject.SetActive(true);
                attributeImage.sprite = fireSprite;
                break;

            case Attribute.Light:
                attributeImage.gameObject.SetActive(true);
                attributeImage.sprite = lightSprite;
                break;
        }
    }
}
