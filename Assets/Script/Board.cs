using System.Collections;
using System.Collections.Generic;
using KPlugin;
using UnityEngine;
using UnityEngine.UI;

public class Board : SingletonUIMonoBehaviour<Board>
{
    #region Parameters
    [SerializeField]
    private Vector2Int _size;
    #endregion

    #region Internal Reference
    [SerializeField]
    private GridLayoutGroup _gridLayoutGroup;

    [SerializeField]
    private Tile[,] tiles;
    #endregion

    #region External Reference
    [SerializeField]
    private Tile tilePrefab;
    #endregion

    void Start()
    {
        Initialize();
    }

    void Update()
    {

    }

    public void Initialize()
    {
        _gridLayoutGroup.cellSize = new Vector2(transform.rect.width / _size.x, transform.rect.height / _size.y);
        tiles = new Tile[_size.x, _size.y];

        for (int i = 0; i < _size.x; i++)
        {
            for (int j = 0; j < _size.y; j++)
            {
                Tile tile = Instantiate(tilePrefab);
                tile.Initialize(new Vector2Int(i, j));
                tile.transform.SetParent(transform);

                tiles[i, j] = tile;
            }
        }
    }
}
