using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using KPlugin;

public class TilesSelector : SingletonUIMonoBehaviour<TilesSelector>
{
    #region Parameters
    [SerializeField]
    private int _numberOfTiles;
    #endregion

    #region Internal Reference
    [SerializeField]
    private GridLayoutGroup _gridLayoutGroup;
    #endregion

    #region External Reference
    [SerializeField]
    private GameObject _tilesSelectorElementPrefab;

    #endregion

    void Start()
    {
        Initialize();
    }

    public void Initialize()
    {
        _gridLayoutGroup.cellSize = new Vector2(transform.rect.width / _numberOfTiles, transform.rect.height);
    }
}
