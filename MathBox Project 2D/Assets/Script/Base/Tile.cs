using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public int myTilePower;

    public bool _isDestroy = false;

    private void Update()
    {
        if (_isDestroy)
        {
            Destroy(this.gameObject);
        }
    }

}
